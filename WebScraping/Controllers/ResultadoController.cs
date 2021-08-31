using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace WebScraping.Controllers
{
    public class ResultadoController : Controller
    {
        public IActionResult Index()
        {
            string url = "http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0K85260Q5OIRSC42046/res/id=historicoHTML/c=cacheLevelPage/=/";
            var response = CallUrl(url).Result;
            ParseHtml(response);
            return View();
        }
        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        private void ParseHtml(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            htmlDoc.Save("Resultado/LotoFacil.csv");                   
        }
       
    }
}
