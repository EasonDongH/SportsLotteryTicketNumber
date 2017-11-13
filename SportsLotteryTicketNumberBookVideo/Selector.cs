using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SportsLotteryTicketNumberBookVideo
{
    //选号器实现
    class Selector
    {
        public List<string[]> SelectNums { get; set; }
        
        public Selector()
        {
            this.SelectNums = new List<string[]>();
        }

        private Random random = new Random();

        //随机选号
        public string[] RandomSelectNumber()
        {
            string[] numArray = new string[7];          
            for (int i = 0; i < 7; i++)
            {
                numArray[i] = random.Next(10).ToString();
            }            
            return numArray;
        }

        /// <summary>
        /// 随机选取多组号码
        /// </summary>
        /// <param name="count">号码组数</param>
        /// <returns></returns>
        public List<string[]> RandomSelectNums(int count)
        {
            List<string[]> numList = new List<string[]>();
            for (int i = 0; i < count; i++)
            {
                numList.Add(RandomSelectNumber());
            }

            return numList;
        }

        //将多条号码连接成完整字符串，用于打印显示
        public List<string> LinkNumbersToStr()
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < SelectNums.Count; i++)
            {
                string numStr = LinkStrSingle(SelectNums[i],i);
                
                temp.Add(numStr);
            }

            return temp;
        }

        //将单条数据连接
        public string LinkStrSingle(string[] tempArray,int index)
        {
            string numStr = string.Empty;
            if (index < 9)
            {
                numStr = $"[第0{index + 1}组号码] ";
            }
            else
            {
                numStr = $"[第{index + 1}组号码] ";
            }
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i == tempArray.Length - 1)//最后一个数字需要多空出一点距离
                    numStr += $"   {tempArray[i]}";
                else
                    numStr += $"{tempArray[i]}  ";
            }

            return numStr;
        }

        /// <summary>
        /// 将选中的号码序列化后保存到相应路径
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveSelectedNum(string fileName,string content)
        {
            DirectoryInfo dir = new DirectoryInfo("Record");
            if (!dir.Exists)
            {
                dir.Create();
            }
            string path = @"Record\" + fileName + ".rec";//相对路径，保存在.exe所在文件夹
            FileStream fs = new FileStream(path,FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, content);
            fs.Close();
        }
    }
}
