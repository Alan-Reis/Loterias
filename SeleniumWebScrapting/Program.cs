using Microsoft.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebScrapting.Model;
using System;
using SeleniumWebScrapting.Repositorio;
using System.Data;

namespace SeleniumWebScrapting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0K85260Q5OIRSC42046/res/id=historicoHTML/c=cacheLevelPage/=/");

            int tr = 2319;
            int td = 19;

            ResultadoLotofacil resultado = new ResultadoLotofacil();

            for (int i = 1; i <= tr; i++)
            {
                for (int j = 1; j <= td; j++)
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
                /*Console.Write(resultado.Consurso + "-");
                Console.Write(resultado.Data + "-");
                Console.Write(resultado.Dezena01 + "-");
                Console.Write(resultado.Dezena02 + "-");
                Console.Write(resultado.Dezena03 + "-");
                Console.Write(resultado.Dezena04 + "-");
                Console.Write(resultado.Dezena05 + "-");
                Console.Write(resultado.Dezena06 + "-");
                Console.Write(resultado.Dezena07 + "-");
                Console.Write(resultado.Dezena08 + "-");
                Console.Write(resultado.Dezena09 + "-");
                Console.Write(resultado.Dezena10 + "-");
                Console.Write(resultado.Dezena11 + "-");
                Console.Write(resultado.Dezena12 + "-");
                Console.Write(resultado.Dezena13 + "-");
                Console.Write(resultado.Dezena14 + "-");
                Console.Write(resultado.Dezena15 + "-");
                Console.Write(resultado.Arrecadacao + "-");
                Console.Write(resultado.Ganhadores);
                Console.WriteLine("");*/

                string connectionString = @"Data Source=DESKTOP-0H4J542\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True";
                
                SqlConnection con = new SqlConnection(connectionString);

                try
                {
                    Console.WriteLine("Conexão estabelecida com sucesso!");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.CommandText = @"INSERT INTO tbl_Lotofacil (Data,Dezena_01,Dezena_02,Dezena_03,Dezena_04,Dezena_05,Dezena_06,Dezena_07,Dezena_08,Dezena_09,Dezena_10,Dezena_11,Dezena_12,Dezena_13,Dezena_14,Dezena_01,Dezena_15,Arrecadacao,Ganhadores) Values(@resultado.Data,@resultado.Dezena01,@resultado.Dezena02,@resultado.Dezena03,@resultado.Dezena04,@resultado.Dezena05,@resultado.Dezena06,@resultado.Dezena07, @resultado.Dezena08, @resultado.Dezena09, @resultado.Dezena10, @resultado.Dezena11, @resultado.Dezena12, @resultado.Dezena13, @resultado.Dezena14, @resultado.Dezena15, @resultado.Arrecadacao, @resultado.Ganhadores)";

                    cmd.Parameters.AddWithValue("@resultado.Data", resultado.Data);
                    cmd.Parameters.AddWithValue("@resultado.Dezena01", resultado.Dezena01);
                    cmd.Parameters.AddWithValue("@resultado.Dezena02", resultado.Dezena02);
                    cmd.Parameters.AddWithValue("@resultado.Dezena03", resultado.Dezena03);
                    cmd.Parameters.AddWithValue("@resultado.Dezena04", resultado.Dezena04);
                    cmd.Parameters.AddWithValue("@resultado.Dezena05", resultado.Dezena05);
                    cmd.Parameters.AddWithValue("@resultado.Dezena06", resultado.Dezena06);
                    cmd.Parameters.AddWithValue("@resultado.Dezena07", resultado.Dezena07);
                    cmd.Parameters.AddWithValue("@resultado.Dezena08", resultado.Dezena08);
                    cmd.Parameters.AddWithValue("@resultado.Dezena09", resultado.Dezena09);
                    cmd.Parameters.AddWithValue("@resultado.Dezena10", resultado.Dezena10);
                    cmd.Parameters.AddWithValue("@resultado.Dezena11", resultado.Dezena11);
                    cmd.Parameters.AddWithValue("@resultado.Dezena12", resultado.Dezena12);
                    cmd.Parameters.AddWithValue("@resultado.Dezena13", resultado.Dezena13);
                    cmd.Parameters.AddWithValue("@resultado.Dezena14", resultado.Dezena14);
                    cmd.Parameters.AddWithValue("@resultado.Dezena15", resultado.Dezena15);
                    cmd.Parameters.AddWithValue("@resultado.Arrecadacao", resultado.Arrecadacao);
                    cmd.Parameters.AddWithValue("@resultado.Ganhadores", resultado.Ganhadores);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Conexão falhou");
                }
            }

           
            driver.Close();

        }
    }
}

