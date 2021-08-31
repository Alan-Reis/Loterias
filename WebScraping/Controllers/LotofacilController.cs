using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Models;

namespace WebScraping.Controllers
{
    public class LotofacilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download()
        {
            string url = "http://html-agility-pack.net/";
            var response = CallUrl(url).Result;
            var linkList = ParseHtml(response);
            WriteToCsv(linkList);

            /*
            var html = @"http://html-agility-pack.net/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            var salvar = node.OuterHtml;

            //Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);
            */

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        private List<string> ParseHtml(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var programmerLinks = htmlDoc.DocumentNode.Descendants("//head/title");
                    //.Where(node => !node.GetAttributeValue("class", "").Contains("tocsection")).ToList();

            List<string> wikiLink = new List<string>();

            foreach (var link in programmerLinks)
            {
                if (link.FirstChild.Attributes.Count > 0)
                    wikiLink.Add("http://html-agility-pack.net/" + link.FirstChild.Attributes[0].Value);
            }

            return wikiLink;

        }

        private void WriteToCsv(List<string> links)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var link in links)
            {
                sb.AppendLine(link);
            }

            System.IO.File.WriteAllText("resultado.csv", sb.ToString());
        }
    }
}