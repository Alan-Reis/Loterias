using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebScrapting.Repositorio
{
    public class Connection
    {
       public static void Conexao()
        {/*
            string connectionString = @"Data Source=DESKTOP-0H4J542\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);


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

            con.Open();

            // 2. Chama o método ExecuteNonQuery para enviar o comando
            cmd.ExecuteNonQuery();

            con.Close();



            //Values(" + resultado.Data + "," + resultado.Dezena01 + "," + resultado.Dezena02 + "," + resultado.Dezena03 + "," + resultado.Dezena04 + "," + resultado.Dezena05 + "," + resultado.Dezena06 + "," + resultado.Dezena07 + "," + resultado.Dezena08 + "," + resultado.Dezena09 + "," + resultado.Dezena10 + "," + resultado.Dezena11 + "," + resultado.Dezena12 + "," + resultado.Dezena13 + "," + resultado.Dezena14 + "," + resultado.Dezena15 + "," + resultado.Arrecadacao + "," + resultado.Ganhadores + ")";

            */
        }

       
    }
}
