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

namespace SportsLotteryTicketNumber
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //Timing();
            timerClock_Tick(null,null);
            timerClock.Start();

            btnClear.Enabled = false;
            btnPrint.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerRandom.Start();
            btnStop.Enabled = true;
        }

        private Random random = new Random();
        private void timerRandom_Tick(object sender, EventArgs e)
        {
            lblNum1.Text = random.Next(0, 9).ToString();
            lblNum2.Text = random.Next(0, 9).ToString();
            lblNum3.Text = random.Next(0, 9).ToString();
            lblNum4.Text = random.Next(0, 9).ToString();
            lblNum5.Text = random.Next(0, 9).ToString();
            lblNum6.Text = random.Next(0, 9).ToString();
            lblNum7.Text = random.Next(0, 9).ToString();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            Timing();
        }

        private void Timing()
        {
            lblYear.Text = DateTime.Now.Year.ToString();
            lblMonth.Text = DateTime.Now.Month.ToString();
            lblDay.Text = DateTime.Now.Day.ToString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //lblWeek.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            string[] Day = new string[] { "日", "一", "二", "三", "四", "五", "六" };           
            lblWeek.Text = Day[Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))].ToString();
        }

        private int count= 0;
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerRandom.Stop();

            
            rTBShowData.Text+= $"[第{++count}组] "+lblNum1.Text + "   " + lblNum2.Text + "   " + lblNum3.Text + "   " + lblNum4.Text + "   " + lblNum5.Text + "   " + lblNum6.Text + "    " + lblNum7.Text + Environment.NewLine;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PrintData\\";
            if (!Directory.Exists(filePath))//如果不存在就创建file文件夹 
            {
                Directory.CreateDirectory(filePath);//创建该文件夹 
            }

            FileStream fs = new FileStream(filePath+DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);            
            sw.WriteLine(rTBShowData.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("打印成功！","打印提示");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            btnClear.Enabled = false;
            rTBShowData.Clear();
            count = 0;
        }
    }
}
