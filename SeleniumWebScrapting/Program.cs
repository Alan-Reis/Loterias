using ClassLibraryLoterica.Models;
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
            Repository repository = new Repository();

            //último concurso no banco de dados
            int bdConcurso = repository.GetConcurso();

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
            
            //percorre quantidade de jogos (linha)
            //pega o último concurso na tabela 
            for (int i = bdConcurso; i <= tr; i++)
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
                                resultado.Consurso = Convert.ToInt32(item.Text);
                                break;
                            case 2:
                                resultado.Data = item.Text;
                                break;
                            case 3:
                                resultado.Dezena01 = item.Text;
                                break;
                            case 4:
                                resultado.Dezena02 = item.Text;
                                break;
                            case 5:
                                resultado.Dezena03 = item.Text;
                                break;
                            case 6:
                                resultado.Dezena04 = item.Text;
                                break;
                            case 7:
                                resultado.Dezena05 = item.Text;
                                break;
                            case 8:
                                resultado.Dezena06 = item.Text;
                                break;
                            case 9:
                                resultado.Dezena07 = item.Text;
                                break;
                            case 10:
                                resultado.Dezena08 = item.Text;
                                break;
                            case 11:
                                resultado.Dezena09 = item.Text;
                                break;
                            case 12:
                                resultado.Dezena10 = item.Text;
                                break;
                            case 13:
                                resultado.Dezena11 = item.Text;
                                break;
                            case 14:
                                resultado.Dezena12 = item.Text;
                                break;
                            case 15:
                                resultado.Dezena13 = item.Text;
                                break;
                            case 16:
                                resultado.Dezena14 = item.Text;
                                break;
                            case 17:
                                resultado.Dezena15 = item.Text;
                                break;
                            case 18:
                                resultado.Arrecadacao = item.Text;
                                break;
                            case 19:
                                resultado.Ganhadores = item.Text;
                                break;
                        }
                    }
                }

                repository.Inserir(resultado.Consurso, resultado.Data, resultado.Dezena01, resultado.Dezena02, resultado.Dezena03,
                                   resultado.Dezena04, resultado.Dezena05, resultado.Dezena06, resultado.Dezena07, resultado.Dezena08, 
                                   resultado.Dezena09, resultado.Dezena10, resultado.Dezena11, resultado.Dezena12, resultado.Dezena13, 
                                   resultado.Dezena14, resultado.Dezena15, resultado.Arrecadacao, resultado.Ganhadores);
            }
            driver.Close();
        }

      
    }
}
