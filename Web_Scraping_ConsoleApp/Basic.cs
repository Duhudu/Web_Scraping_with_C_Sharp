using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Scraping_ConsoleApp
{
    public class Basic
    {
        List<string> list;
        List<string> uniqueList;
        public Basic()
        {
            list = new List<string>();
            list.Add("Apple");
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Orange");
            uniqueList = new List<string>();

            string longestString = "";
            
            foreach (var item in list)
            {
                int count = 0;
                if (item.Length > longestString.Length)
                {
                    longestString = item;
                }
                foreach (var otherItem in list)
                {
                    if (item == otherItem)
                    {
                        count++;
                    }
                }
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
                //Console.WriteLine(count);
                foreach(var UI in uniqueList)
                {
                    //Console.WriteLine(UI);
                }
            }
            
        }
    }
}
