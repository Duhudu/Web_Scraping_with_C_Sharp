using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Scraping_ConsoleApp
{
    //create class
    public class Book
    {
        public string Title { get; set; }
        public string Price { get; set; }
    }
    public class signleWeb
    {
        //First create url
        string url = "https://books.toscrape.com/index.html";
        //setup broswer to download html
        HtmlWeb web = new HtmlWeb();

        public void signleValue()
        {
            //download and convert to doucment 
            HtmlDocument document = web.Load(url);
            // XPath to find the data
            var nodes = document.DocumentNode.SelectNodes("//article[@class='product_pod']");
            //check for null
            if(nodes != null)
            {
                //foreach loop to add data
                foreach (var item in nodes)
                {
                    var title = item.SelectSingleNode(".//h3");
                    if(title != null)
                    {
                        string cleanTitle = title.InnerText;
                        Console.WriteLine(cleanTitle);
                    }
                }
            }
        }

        public void MultipleValue()
        {

            List<Book> books = new List<Book>();
            //download html and convert to object
            HtmlDocument document = web.Load(url);
            //Set XPath
            var nodes = document.DocumentNode.SelectNodes("//article[@class='product_pod']");
            //check for null
            if( nodes != null)
                {
                   foreach(var item in nodes)
                   {
                        //get the sub item xpath
                        var title = item.SelectSingleNode(".//h3");
                        var price = item.SelectSingleNode(".//div[@class='product_price']/p");
                        //check for null
                        if(title != null &&  price != null)
                        {
                            //create object from book list
                            var bookData = new Book
                            {
                                Title = title.InnerText,
                                Price = price.InnerText,
                            };
                            books.Add(bookData);
                            Console.WriteLine($"Title: {bookData.Title}");
                            Console.WriteLine($"Price: {bookData.Price}");
                            Console.WriteLine("-------------------");
                    }
                      
                   }
                    
            }

        }
    }
}
