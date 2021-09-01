using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
                    

            for (int i = 0; i <= tr; i++)
            {
                for(int j = 0; j <= td; j++)
                {
                    var table = driver.FindElements(By.CssSelector("body > table > tbody > tr:nth-child(" + i + ") > td:nth-child(" + j + ")"));

                    foreach (var item in table)
                    {
                       switch (j)
                        {
                            case 1:
                                 string consurso = item.Text;
                                break;
                            case 2:
                                string data = item.Text;
                                break;
                            case 3:
                                string dezena01 = item.Text;
                                break;
                            case 4:
                                string dezena02 = item.Text;
                                break;
                            case 5:
                                string dezena03 = item.Text;
                                break;
                            case 6:
                                string dezena04 = item.Text;
                                break;
                            case 7:
                                string dezena05 = item.Text;
                                break;
                            case 8:
                                string dezena06 = item.Text;
                                break;
                            case 9:
                                string dezena07 = item.Text;
                                break;
                            case 10:
                                string dezena08 = item.Text;
                                break;
                            case 11:
                                string dezena09 = item.Text;
                                break;
                            case 12:
                                string dezena10 = item.Text;
                                break;
                            case 13:
                                string dezena11 = item.Text;
                                break;
                            case 14:
                                string dezena12 = item.Text;
                                break;
                            case 15:
                                string dezena13 = item.Text;
                                break;
                            case 16:
                                string dezena14 = item.Text;
                                break;
                            case 17:
                                string dezena15 = item.Text;
                                break;
                            case 18:
                                string arecadacao = item.Text;
                                break;
                            case 19:
                                string ganhadores = item.Text;
                                break;                            
                        }                      

                    }
                }
                
            }

            driver.Close();

        }
    }
}
