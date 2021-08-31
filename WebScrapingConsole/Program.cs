using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace WebScrapingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();
                        
            HtmlAgilityPack.HtmlDocument document = website.Load("C:\\Users/alanc/source/repos/Loterias/WebScraping/Resultado/LotoFacil.csv");
            
            var td = document.DocumentNode.SelectNodes("//td").ToList();
            //var tr = document.DocumentNode.SelectNodes("//tr").ToList();
            //var coinData = new Dictionary<string, string>();
                        
                int total = 1;

                foreach (var tds in td)
                {

                
                //coinData.Add(tds.ChildNodes[2].InnerText, tds.ChildNodes[3].InnerText);
               
                total++;

                 if(total <= 34)
                 {
                     Console.Write(tds.InnerText);
                 }
                 else
                 {
                     Console.WriteLine("");
                     total = 1;
                 }
            }
                



        }
        public static void Ler()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users/alanc/source/repos/Loterias/WebScrapingConsole/teste.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
       

        public static void LerLinha()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\\Users/alanc/source/repos/Loterias/WebScrapingConsole/resultado.csv");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }

        public static void Pesquisar()
        {
            String varPalavra = "tr";

      StreamReader re = File.OpenText("C:\\Users/alanc/source/repos/Loterias/WebScrapingConsole/resultado.csv");
      string input = re.ReadToEnd();

      if (input.IndexOf(varPalavra) > -1)
        Console.WriteLine("Existe a palavra '" + varPalavra + "' no arquivo txt");
      else
        Console.WriteLine("Não existe a palavra '" + varPalavra + "' no arquivo txt");

      re.Close();
        }
    }
}
