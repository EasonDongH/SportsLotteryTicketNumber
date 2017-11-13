using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SportsLotteryTicketNumberBook
{
    public partial class FrmMain : Form
    {
        private PickDevice pickDevice = new PickDevice();
        public FrmMain()
        {
            InitializeComponent();

            timerClock_Tick(null,null);
            this.btnStop.Enabled = false;
            this.btnPrint.Enabled = false;
            this.btnClear.Enabled = false;     
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerRandom.Start();
            btnStop.Enabled = true;
        }

        
        private void timerRandom_Tick(object sender, EventArgs e)
        {
            int[] nums = pickDevice.RandomNumber();
            if (nums.Length == 7)
            {
                lblNum1.Text = nums[0].ToString();
                lblNum2.Text = nums[1].ToString();
                lblNum3.Text = nums[2].ToString();
                lblNum4.Text = nums[3].ToString();
                lblNum5.Text = nums[4].ToString();
                lblNum6.Text = nums[5].ToString();
                lblNum7.Text = nums[6].ToString();                
            }

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblYear.Text = pickDevice.MyClock.Year;
            lblMonth.Text = pickDevice.MyClock.Month;
            lblDay.Text = pickDevice.MyClock.Day;
            lblTime.Text = pickDevice.MyClock.Time;
            lblWeek.Text = pickDevice.MyClock.Week;
        }

        private string splitChar = "   ";
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerRandom.Stop();
            btnPrint.Enabled = true;
            btnClear.Enabled = true;

            string selectNums = $"[第{pickDevice.SelectedNum.Count + 1}组] " + lblNum1.Text + splitChar + lblNum2.Text + splitChar + lblNum3.Text + splitChar + lblNum4.Text + splitChar + lblNum5.Text + splitChar + lblNum6.Text + splitChar +"  " + lblNum7.Text;
            pickDevice.SelectedNum.Add(selectNums);
            rTBShowData.Text += selectNums + Environment.NewLine;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pickDevice.PrintNum();
            btnClear_Click(null, null);
            MessageBox.Show("打印成功！","打印提示");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTBShowData.Clear();
            pickDevice.SelectedNum.Clear();

            btnStop.Enabled = false;
            btnPrint.Enabled = false;
            btnClear.Enabled = false;

            lblNum1.Text = "0";
            lblNum2.Text = "0";
            lblNum3.Text = "0";
            lblNum4.Text = "0";
            lblNum5.Text = "0";
            lblNum6.Text = "0";
            lblNum7.Text = "0";
        }
    }
}
