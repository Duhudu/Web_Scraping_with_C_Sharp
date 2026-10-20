

using HtmlAgilityPack;
using Web_Scraping_ConsoleApp;

Console.WriteLine("Hello, World!");
/*
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}
*/

string url = "http://quotes.toscrape.com/";

//Create a virtual browser to load the page
HtmlWeb web = new HtmlWeb();

//download the html into a document object 
HtmlDocument doc = web.Load(url);

//Use XPath to find and collect the data
var node = doc.DocumentNode.SelectNodes("//span[@class='text']");

//check for null
if (node != null)
{
    int counter = 1;

    foreach (var data in node)
    {
        //get the text 
        string cleanText = data.InnerText;
       // Console.WriteLine($"Quote {counter} {cleanText}");
        //Console.WriteLine("----");
        counter++;
    }
}
else
{
    Console.WriteLine("Could not find any quotes. The XPath might be wrong.");
}
Console.WriteLine("-------------------");
Console.WriteLine("Mul Data Method");
Console.WriteLine("-------------------");
//MulData mydata = new MulData();
//mydata.MulDataMethod();
Console.WriteLine("-------------------");
Basic basic = new Basic();

Exercises exercises = new Exercises();
//exercises.GetNubmers();

signleWeb singleWeb1 = new signleWeb();
singleWeb1.MultipleValue();
//keep console open
Console.ReadLine();
