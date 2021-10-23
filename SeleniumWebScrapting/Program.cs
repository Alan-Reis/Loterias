using ClassLibraryLoterica.Models;
using ClassLibraryRepository;
using Microsoft.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data;

namespace SeleniumWebScrapting
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryLotofacil repository = new RepositoryLotofacil();

            //último concurso no banco de dados
            int TotalConcursoDB = repository.GetConcurso();



            IWebDriver driver = new ChromeDriver();
            //colocar a url que deseja fazer o scraping
            driver.Navigate().GoToUrl("http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0K85260Q5OIRSC42046/res/id=historicoHTML/c=cacheLevelPage/=/");

            //pega o último concurso sorteado
            var totalConcurso = driver.FindElements(By.CssSelector("body > table > tbody > tr"));

            //número de concurso
            int tr = Convert.ToInt32(totalConcurso.Count);
            //número da coluna até onde deseja pegar
            int td = 19;

            Lotofacil resultado = new Lotofacil();

            //Consicional para evitar o erro de pegar valores repetidos no banco de dados e no site
            //if (TotalConcursoDB != tr)
           //{
                //percorre quantidade de jogos (linha)
                //pega o último concurso na tabela 
                for (int i = TotalConcursoDB; i <= tr; i++)
                {
                    //percorre as colunas, nesse caso setando até 19
                    for (int j = 1; j <= td; j++)
                    {
                        //pega pelo Selector as linha e colunas
                        var table = driver.FindElements(By.CssSelector("body > table > tbody > tr:nth-child(" + i + ") > td:nth-child(" + j + ")"));

                        foreach (var item in table)
                        {
                            //seta os valores nas variaveis
                            switch (j)
                            {
                                case 1:
                                    resultado.ConcursoID = Convert.ToInt32(item.Text);
                                    break;
                                case 2:
                                    resultado.Data = item.Text;
                                    break;
                                case 3:
                                    resultado.Dezena_01 = Convert.ToInt32(item.Text);
                                    break;
                                case 4:
                                    resultado.Dezena_02 = Convert.ToInt32(item.Text);
                                    break;
                                case 5:
                                    resultado.Dezena_03 = Convert.ToInt32(item.Text);
                                    break;
                                case 6:
                                    resultado.Dezena_04 = Convert.ToInt32(item.Text);
                                    break;
                                case 7:
                                    resultado.Dezena_05 = Convert.ToInt32(item.Text);
                                    break;
                                case 8:
                                    resultado.Dezena_06 = Convert.ToInt32(item.Text);
                                    break;
                                case 9:
                                    resultado.Dezena_07 = Convert.ToInt32(item.Text);
                                    break;
                                case 10:
                                    resultado.Dezena_08 = Convert.ToInt32(item.Text);
                                    break;
                                case 11:
                                    resultado.Dezena_09 = Convert.ToInt32(item.Text);
                                    break;
                                case 12:
                                    resultado.Dezena_10 = Convert.ToInt32(item.Text);
                                    break;
                                case 13:
                                    resultado.Dezena_11 = Convert.ToInt32(item.Text);
                                    break;
                                case 14:
                                    resultado.Dezena_12 = Convert.ToInt32(item.Text);
                                    break;
                                case 15:
                                    resultado.Dezena_13 = Convert.ToInt32(item.Text);
                                    break;
                                case 16:
                                    resultado.Dezena_14 = Convert.ToInt32(item.Text);
                                    break;
                                case 17:
                                    resultado.Dezena_15 = Convert.ToInt32(item.Text);
                                    break;
                                case 18:
                                    resultado.Arrecadacao = item.Text;
                                    break;
                                case 19:
                                    resultado.Ganhadores = Convert.ToInt32(item.Text);
                                    break;
                            }
                        }
                    }
                    repository.Inserir(resultado.ConcursoID, resultado.Data, resultado.Dezena_01, resultado.Dezena_02, resultado.Dezena_03,
                                  resultado.Dezena_04, resultado.Dezena_05, resultado.Dezena_06, resultado.Dezena_07, resultado.Dezena_08,
                                  resultado.Dezena_09, resultado.Dezena_10, resultado.Dezena_11, resultado.Dezena_12, resultado.Dezena_13,
                                  resultado.Dezena_14, resultado.Dezena_15, resultado.Arrecadacao, resultado.Ganhadores);
                }

            //}

            driver.Close();
            Environment.Exit(1);
        }
    }
}
