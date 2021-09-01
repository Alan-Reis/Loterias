using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebScrapting.Model;
using System;

namespace SeleniumWebScrapting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0K85260Q5OIRSC42046/res/id=historicoHTML/c=cacheLevelPage/=/");

            int tr = 2319;
            int td = 17;

            ResultadoLotofacil resultado = new ResultadoLotofacil();

            for (int i = 0; i <= tr; i++)
            {
                for (int j = 0; j <= td; j++)
                {
                    var table = driver.FindElements(By.CssSelector("body > table > tbody > tr:nth-child(" + i + ") > td:nth-child(" + j + ")"));

                    foreach (var item in table)
                    {
                        switch (j)
                        {
                            case 1:
                                resultado.Consurso = item.Text;
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

            }

            

            driver.Close();

        }


    }
}