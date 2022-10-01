// See https://aka.ms/new-console-template for more information
using Crawler.Sevices;
using System;

ParseSite parseSite=new();
FileWriter file = new();

var startUrl = "https://www.bbcstudios.com/";
var Result = await parseSite.GetUrls(startUrl);
foreach(var url in Result)
{
    await file.WriteToFile(url, @"F:\Dev\Web crawler\Neveling Reply\WebCrawler\Crawler.Client\NewFolder");
    Console.WriteLine("we found this Link " +url);
    
}


file.WriteToFile(Result, @"F:\Dev\Web crawler\Neveling Reply\WebCrawler\Crawler.Client\NewFolder\TextFile1.txt");

Console.ReadLine();
