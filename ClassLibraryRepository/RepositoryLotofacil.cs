using ClassLibraryLoterica.Models;
using ClassLibraryService;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryRepository
{
    public class RepositoryLotofacil : Lotofacil, ILotofacil
    {
        string connectionString = @"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True";

        public IEnumerable<Lotofacil> GetAllConcursos()
        {
            List<Lotofacil> concursos = new List<Lotofacil>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 10 * FROM [dbo].[LotofacilConcursos]";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Lotofacil lotofacil = new Lotofacil();
                    lotofacil.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                    lotofacil.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                    lotofacil.Dezena_01 = rdr["Dezena_01"].ToString();
                    lotofacil.Dezena_02 = rdr["Dezena_02"].ToString();
                    lotofacil.Dezena_03 = rdr["Dezena_03"].ToString();
                    lotofacil.Dezena_04 = rdr["Dezena_04"].ToString();
                    lotofacil.Dezena_05 = rdr["Dezena_05"].ToString();
                    lotofacil.Dezena_06 = rdr["Dezena_06"].ToString();
                    lotofacil.Dezena_07 = rdr["Dezena_07"].ToString();
                    lotofacil.Dezena_08 = rdr["Dezena_08"].ToString();
                    lotofacil.Dezena_09 = rdr["Dezena_09"].ToString();
                    lotofacil.Dezena_10 = rdr["Dezena_10"].ToString();
                    lotofacil.Dezena_11 = rdr["Dezena_11"].ToString();
                    lotofacil.Dezena_12 = rdr["Dezena_12"].ToString();
                    lotofacil.Dezena_13 = rdr["Dezena_13"].ToString();
                    lotofacil.Dezena_14 = rdr["Dezena_14"].ToString();
                    lotofacil.Dezena_15 = rdr["Dezena_15"].ToString();
                    lotofacil.Arrecadacao = rdr["Arrecadacao"].ToString();
                    lotofacil.Ganhadores = rdr["Ganhadores"].ToString();
                    concursos.Add(lotofacil);
                }
                con.Close();
            }
            return concursos;
        }
        
        public Lotofacil GetConcurso(int? id)
        {
            Lotofacil concurso = new Lotofacil();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbo].[LotofacilConcursos] WHERE ConcursoID = " + id;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                concurso.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                concurso.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                concurso.Dezena_01 = rdr["Dezena_01"].ToString();
                concurso.Dezena_02 = rdr["Dezena_02"].ToString();
                concurso.Dezena_03 = rdr["Dezena_03"].ToString();
                concurso.Dezena_04 = rdr["Dezena_04"].ToString();
                concurso.Dezena_05 = rdr["Dezena_05"].ToString();
                concurso.Dezena_06 = rdr["Dezena_06"].ToString();
                concurso.Dezena_07 = rdr["Dezena_07"].ToString();
                concurso.Dezena_08 = rdr["Dezena_08"].ToString();
                concurso.Dezena_09 = rdr["Dezena_09"].ToString();
                concurso.Dezena_10 = rdr["Dezena_10"].ToString();
                concurso.Dezena_11 = rdr["Dezena_11"].ToString();
                concurso.Dezena_12 = rdr["Dezena_12"].ToString();
                concurso.Dezena_13 = rdr["Dezena_13"].ToString();
                concurso.Dezena_14 = rdr["Dezena_14"].ToString();
                concurso.Dezena_15 = rdr["Dezena_15"].ToString();
                concurso.Arrecadacao = rdr["Arrecadacao"].ToString();
                concurso.Ganhadores = rdr["Ganhadores"].ToString();
                
                con.Close();
            }
            return concurso;
        }
    }
}
