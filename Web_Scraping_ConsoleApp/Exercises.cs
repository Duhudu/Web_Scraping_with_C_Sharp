using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Scraping_ConsoleApp
{
    public class Exercises
    {
        List<int> productIds = new List<int>
{
            101, 205, 309, 101, 450, 205, 501
        };
        List<int> seenItems;

        public Exercises()
        {
            seenItems = new List<int>();

            foreach(var item in productIds)
            {
                //Contains to check if the item is already in the list
                if (seenItems.Contains(item))
                {
                    Console.WriteLine(item);
                    break;
                }
                else
                {
                    seenItems.Add(item);
                }

            }
        }

        List<int> numbers = new List<int>
{
            4, 7, 2, 9, 7, 4, 7, 10, 2
        };
        public void GetNubmers()
        {
            List<int> num = new List<int>();
            
            int mostCount = 0;
            int mostNumber = 0;

            foreach (var number in numbers)
            {
                var count = 0;
                foreach (var item in numbers)
                {
                    if (number == item)
                    {
                        count++;
                    }
                }

                if (count > mostCount)
                {
                    mostCount = count;
                    mostNumber = number;
                }
            }
            Console.WriteLine($"Most count: {mostCount}");
            Console.WriteLine($"Most number: {mostNumber}");
        }

    }
}
