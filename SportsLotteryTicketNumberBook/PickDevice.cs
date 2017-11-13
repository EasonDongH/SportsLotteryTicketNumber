using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SportsLotteryTicketNumberBook
{
    class PickDevice
    {
        private Random random;
        public List<string> SelectedNum { get; set; }
        private Clock myClock;

        public PickDevice()
        {
            this.random = new Random();
            this.SelectedNum = new List<string>();
            this.myClock = new Clock();
        }

        private string[] myWeek = { "日", "一", "二", "三", "四", "五", "六" };
        public Clock MyClock
        {
            get
            {
                this.myClock.Year = DateTime.Now.Year.ToString();
                this.myClock.Month = DateTime.Now.Month.ToString();
                this.myClock.Day = DateTime.Now.Day.ToString();
                this.myClock.Time = DateTime.Now.ToLongTimeString();
                this.myClock.Week = myWeek[Convert.ToInt32(DateTime.Now.DayOfWeek)];

                return myClock;
            }
        }

        public int[] RandomNumber()
        {
            int[] numbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                numbers[i] = random.Next(10);
            }

            return numbers;
        }

        public void PrintNum()
        {
            string filePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PrintData\\";
            if (!Directory.Exists(filePath))//如果不存在就创建file文件夹 
            {
                Directory.CreateDirectory(filePath);//创建该文件夹 
            }

            FileStream fs = new FileStream(filePath + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var select in SelectedNum)
            {
                sw.Write(select+Environment.NewLine);
            }
            sw.WriteLine();
            sw.Close();
            fs.Close();           
        }

    }
}
