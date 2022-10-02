using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Sevices
{
    public  class FileWriter : IFileWriter
    {
        public Task WriteToFile(List<string> items, string path)
        {
            using (var file = File.CreateText(path))
            {
                foreach (var line in items)
                {
                    file.WriteLine(line);
                }
            }
            return Task.CompletedTask;
        }

        public  Task WriteToFile(string url, string path)
        {
            string fileName = Path.GetRandomFileName();
            path = Path.Combine(path, fileName+".txt");
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var file = File.CreateText(path);
            doc.Save(file);
            return Task.CompletedTask;

        }
      
    }
}
