using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsLotteryTicketNumberBookVideo
{
    public partial class FrmMain : Form
    {
        private Selector selector = new Selector();
        private PrintDocument printDoc = new PrintDocument();//创建打印对象

        public FrmMain()
        {
            InitializeComponent();

            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            btnConfirmNum.Enabled = false;

            //关联打印对象的事件
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.LotteryPrintPage);
        }

        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        #region 窗口操作
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region 随机选号
        private void btnRandomSelectNum_Click(object sender, EventArgs e)
        {
            RandomTimer.Start();
            btnConfirmNum.Enabled = true;
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            string[] numList = this.selector.RandomSelectNumber();
            this.lblNum1.Text = numList[0];
            this.lblNum2.Text = numList[1];
            this.lblNum3.Text = numList[2];
            this.lblNum4.Text = numList[3];
            this.lblNum5.Text = numList[4];
            this.lblNum6.Text = numList[5];
            this.lblNum7.Text = numList[6];
        }
        #endregion

        #region 确认选号
        private void btnConfirmNum_Click(object sender, EventArgs e)
        {           
            RandomTimer.Stop();
            string[] str = new string[7]
            {
                lblNum1.Text,
                lblNum2.Text,
                lblNum3.Text,
                lblNum4.Text,
                lblNum5.Text,
                lblNum6.Text,
                lblNum7.Text                
            };
            this.selector.SelectNums.Add(str);
            //ShowInfo();
            lbNumList.Items.Add(this.selector.LinkStrSingle(str,this.lbNumList.Items.Count));
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion

        //将信息显示到listbox控件
        private void ShowInfo()
        {
            lbNumList.Items.Clear();
            lbNumList.Items.AddRange(this.selector.LinkNumbersToStr().ToArray());

            btnClear.Enabled = true;
            btnDelete.Enabled = true;
        }

        //组选号码
        private void btnRandomSelectNums_Click(object sender, EventArgs e)
        {
            RandomTimer.Stop();

            this.selector.SelectNums.Clear();
            this.selector.SelectNums.AddRange(this.selector.RandomSelectNums(Convert.ToInt32(txtNumCount.Text)));

            ShowInfo();
        }

        //手写号码
        private void btnWriteNum_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() == string.Empty || txtNum2.Text.Trim() == string.Empty || txtNum3.Text.Trim() == string.Empty || txtNum4.Text.Trim() == string.Empty || txtNum5.Text.Trim() == string.Empty || txtNum6.Text.Trim() == string.Empty || txtNum7.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请检查","提醒");
                return;
            }

            string[] str = new string[7]
                {
                    txtNum1.Text,
                    txtNum2.Text,
                    txtNum3.Text,
                    txtNum4.Text,
                    txtNum5.Text,
                    txtNum6.Text,
                    txtNum7.Text
                };
            this.selector.SelectNums.Add(str);
            ShowInfo();
        }

        //删除选中的号码
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.lbNumList.SelectedIndex;
            this.lbNumList.Items.RemoveAt(index);
            this.selector.SelectNums.RemoveAt(index);
            ShowInfo();
        }

        //清除listbox里面所有内容
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbNumList.Items.Clear();
            this.selector.SelectNums.Clear();

            this.lblNum1.Text = "0";
            this.lblNum2.Text = "0";
            this.lblNum3.Text = "0";
            this.lblNum4.Text = "0";
            this.lblNum5.Text = "0";
            this.lblNum6.Text = "0";
            this.lblNum7.Text = "0";

            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            btnConfirmNum.Enabled = false;
        }

        //将listbox内容打印
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lbNumList.Items.Count < 1)
            {
                MessageBox.Show("无号码打印！","提示");
                return;
            }
            this.printDoc.Print();
        }

        //具体打印实现过程
        private void LotteryPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string serialNum = DateTime.Now.ToString("yyyyMMddHHmmssms");//流水号（生成条码使用）

            Printer print = new Printer();
            print.PrintLottery(e, serialNum, selector.LinkNumbersToStr());//调用前面编写的打印方法
            this.selector.SaveSelectedNum(serialNum, lbNumList.Items.ToString());

            btnClear_Click(null, null);//打印完毕后清空
        }

    }
}
