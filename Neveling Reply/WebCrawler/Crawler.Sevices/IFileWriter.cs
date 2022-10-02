using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Sevices
{
    public  interface IFileWriter
    {
        Task WriteToFile(string  url, string path);

    }
}
