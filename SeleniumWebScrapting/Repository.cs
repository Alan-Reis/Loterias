using ClassLibraryLoterica.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebScrapting
{
    public class Repository
    {
        public void Inserir(int Consurso, string Data, string D1, string D2, string D3, string D4, string D5,
            string D6, string D7, string D8, string D9, string D10, string D11, string D12, string D13, string D14, 
            string D15, string Arrecadacao, string Ganhadores)
        {
            
            //definição da string de conexão
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True");

            //definição do comando sql
            string sql1 = "SET IDENTITY_INSERT [LotofacilConcursos] ON";
            string sql = "INSERT INTO LotofacilConcursos(ConcursoID, Data, Dezena_01, Dezena_02, Dezena_03, Dezena_04, Dezena_05, Dezena_06, Dezena_07, Dezena_08, Dezena_09, Dezena_10, Dezena_11, Dezena_12, Dezena_13, Dezena_14, Dezena_15, Arrecadacao, Ganhadores) " +
            "Values(@Concurso, @Data, @Dezena01, @Dezena02, @Dezena03, @Dezena04, @Dezena05, @Dezena06, @Dezena07, @Dezena08, @Dezena09, @Dezena10, @Dezena11, @Dezena12, @Dezena13, @Dezena14, @Dezena15, @Arrecadacao, @Ganhadores)";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlCommand cmd = new SqlCommand(sql, con);

                //passa os valores da variaveis para os valores do insert
                cmd.Parameters.Add(new SqlParameter("@Concurso", Consurso));
                cmd.Parameters.Add(new SqlParameter("@Data", Data));
                cmd.Parameters.Add(new SqlParameter("@Dezena01", D1));
                cmd.Parameters.Add(new SqlParameter("@Dezena02", D2));
                cmd.Parameters.Add(new SqlParameter("@Dezena03", D3));
                cmd.Parameters.Add(new SqlParameter("@Dezena04", D4));
                cmd.Parameters.Add(new SqlParameter("@Dezena05", D5));
                cmd.Parameters.Add(new SqlParameter("@Dezena06", D6));
                cmd.Parameters.Add(new SqlParameter("@Dezena07", D7));
                cmd.Parameters.Add(new SqlParameter("@Dezena08", D8));
                cmd.Parameters.Add(new SqlParameter("@Dezena09", D9));
                cmd.Parameters.Add(new SqlParameter("@Dezena10", D10));
                cmd.Parameters.Add(new SqlParameter("@Dezena11", D11));
                cmd.Parameters.Add(new SqlParameter("@Dezena12", D12));
                cmd.Parameters.Add(new SqlParameter("@Dezena13", D13));
                cmd.Parameters.Add(new SqlParameter("@Dezena14", D14));
                cmd.Parameters.Add(new SqlParameter("@Dezena15", D15));
                cmd.Parameters.Add(new SqlParameter("@Arrecadacao", Arrecadacao));
                cmd.Parameters.Add(new SqlParameter("@Ganhadores", Ganhadores));

                //abre a conexao
                con.Open();
                Console.WriteLine("Conexão estabelecida com sucesso!");
                //executa o comando com os parametros que foram adicionados acima
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                //fecha a conexao
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexão falhou!" + ex);
            }
        }

        public int GetConcurso()
        {
            Lotofacil resultado = new Lotofacil();

            //definição da string de conexão
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True");

            //definição do comando sql
            string sql = "SELECT TOP 1 ConcursoID FROM [dbo].[LotofacilConcursos] ORDER BY ConcursoID DESC";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();

                //SqlDataReader sqlData = cmd.ExecuteReader();
                int count = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                return count;

                //fecha a conexao
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}
