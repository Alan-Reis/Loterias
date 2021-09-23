using Microsoft.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebScrapting.Model;
using System;
using System.Data;

namespace SeleniumWebScrapting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //colocar a url que deseja fazer o scraping
            driver.Navigate().GoToUrl("http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbz8vTxNDRy9_Y2NQ13CDA0sTIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wBmoxN_FydLAGAgNTKEK8DkRrACPGwpyQyMMMj0VAcySpRM!/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0K85260Q5OIRSC42046/res/id=historicoHTML/c=cacheLevelPage/=/");

            //número de concurso +1
            int tr = 2330;
            //número da coluna até onde deseja pegar
            int td = 19;

            ResultadoLotofacil resultado = new ResultadoLotofacil();

            //percorre quantidade de jogos (linha)
            //o valor de (i) é número do concurso que deseja pegar até o atual
            for (int i = 1; i <= tr; i++)
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
                
                //definição da string de conexão
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True");

                //definição do comando sql
                string sql = "INSERT INTO LotofacilConcursos(ConcursoID, Data, Dezena_01, Dezena_02, Dezena_03, Dezena_04, Dezena_05, Dezena_06, Dezena_07, Dezena_08, Dezena_09, Dezena_10, Dezena_11, Dezena_12, Dezena_13, Dezena_14, Dezena_15, Arrecadacao, Ganhadores) " +
                "Values(@Concurso, @Data, @Dezena01, @Dezena02, @Dezena03, @Dezena04, @Dezena05, @Dezena06, @Dezena07, @Dezena08, @Dezena09, @Dezena10, @Dezena11, @Dezena12, @Dezena13, @Dezena14, @Dezena15, @Arrecadacao, @Ganhadores)";

                try
                {                  
                    //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                    SqlCommand cmd = new SqlCommand(sql, con);

                    //passa os valores da variaveis para os valores do insert
                    cmd.Parameters.Add(new SqlParameter("@Concurso", resultado.Consurso));
                    cmd.Parameters.Add(new SqlParameter("@Data", resultado.Data));
                    cmd.Parameters.Add(new SqlParameter("@Dezena01", resultado.Dezena01));
                    cmd.Parameters.Add(new SqlParameter("@Dezena02", resultado.Dezena02));
                    cmd.Parameters.Add(new SqlParameter("@Dezena03", resultado.Dezena03));
                    cmd.Parameters.Add(new SqlParameter("@Dezena04", resultado.Dezena04));
                    cmd.Parameters.Add(new SqlParameter("@Dezena05", resultado.Dezena05));
                    cmd.Parameters.Add(new SqlParameter("@Dezena06", resultado.Dezena06));
                    cmd.Parameters.Add(new SqlParameter("@Dezena07", resultado.Dezena07));
                    cmd.Parameters.Add(new SqlParameter("@Dezena08", resultado.Dezena08));
                    cmd.Parameters.Add(new SqlParameter("@Dezena09", resultado.Dezena09));
                    cmd.Parameters.Add(new SqlParameter("@Dezena10", resultado.Dezena10));
                    cmd.Parameters.Add(new SqlParameter("@Dezena11", resultado.Dezena11));
                    cmd.Parameters.Add(new SqlParameter("@Dezena12", resultado.Dezena12));
                    cmd.Parameters.Add(new SqlParameter("@Dezena13", resultado.Dezena13));
                    cmd.Parameters.Add(new SqlParameter("@Dezena14", resultado.Dezena14));
                    cmd.Parameters.Add(new SqlParameter("@Dezena15", resultado.Dezena15));
                    cmd.Parameters.Add(new SqlParameter("@Arrecadacao", resultado.Arrecadacao));
                    cmd.Parameters.Add(new SqlParameter("@Ganhadores", resultado.Ganhadores));

                    //abre a conexao
                    con.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso!" + resultado.Consurso);
                    //executa o comando com os parametros que foram adicionados acima
                    cmd.ExecuteNonQuery();
                    //fecha a conexao
                    con.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Conexão falhou!" + ex);
                }
            }
            driver.Close();
        }
    }
}
