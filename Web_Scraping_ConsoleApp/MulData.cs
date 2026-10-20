using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Scraping_ConsoleApp
{
    //Class
    public class Books
    {
        public string Title { get; set; }
        public string Price { get; set; }
    }
    public class MulData
    {
        string url = "https://books.toscrape.com/?";

        //create a list to store Book objects
        List<Books> books = new List<Books>();
        //set browser
        HtmlWeb web = new HtmlWeb();
        //download and convert in to document object
        HtmlDocument doc;

        public void MulDataMethod()
        {
            doc = web.Load(url);

            //Xpath
            var nodes = doc.DocumentNode.SelectNodes("//article[@class='product_pod']");

            if (nodes != null)
            {
                //foreach to get the data
                foreach(var data in nodes)
                {
                    var titleNode = data.SelectSingleNode(".//h3");
                    var priceNode = data.SelectSingleNode(".//div[@class='product_price']/p");

                    //check for null 
                    if (titleNode != null && priceNode != null)
                    {
                        //create object from Books 
                        var items = new Books
                        {
                            Title = titleNode.InnerText,
                            Price = priceNode.InnerText
                        };
                        books.Add(items);
                    }
                    
               
                }
                //print data
                foreach(var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Price: {book.Price}");
                    Console.WriteLine("-------------------");
                }

            }
            else
            {
                Console.Write("Error");
            }
        }



    }
}
