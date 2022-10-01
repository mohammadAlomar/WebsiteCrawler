using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Crawler.Sevices
{
    public class ParseSite : IParseSite
    {
        public Task<List<string>> GetUrls(string url)
        {
            // we can do more here to  check url is valid or not
            List<string> result = new List<string>();
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var body = doc.DocumentNode.SelectSingleNode("//body");

            foreach (var node in body.Descendants())
            {
                
                var Link = node.Descendants("a")?.FirstOrDefault()?.ChildAttributes("href")?.FirstOrDefault()?.Value;

                if (string.IsNullOrEmpty(Link) || result.Contains(Link)) continue; 
                if(Link.Contains("https://") || Link.Contains("http://")) 
                result.Add(Link);
                
               


            }
            return Task.FromResult(result) ;
        }
        
    }
}
