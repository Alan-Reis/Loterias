using ClassLibraryLoterica.Models;
using ClassLibraryService;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryRepository
{
    public class RepositoryLotofacil : ILotofacil
    {
        string connectionString = @"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True";

        public IEnumerable<Lotofacil> GetAllConcursos()
        {
            List<Lotofacil> listConcursos = new List<Lotofacil>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT FuncionarioId, Nome,Cidade, Departamento,Sexo from Funcionarios", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Lotofacil lotofacil = new Lotofacil();
                    lotofacil.Consurso = Convert.ToInt32(rdr["Concurso"]);
                    lotofacil.Data = rdr["Data"].ToString();
                    lotofacil.Dezena01 = rdr["Dezena01"].ToString();
                    lotofacil.Dezena02 = rdr["Dezena02"].ToString();
                    lotofacil.Dezena03 = rdr["Dezena03"].ToString();
                    listConcursos.Add(lotofacil);
                }
                con.Close();
            }
            return listConcursos;
        }
        
        public Lotofacil GetConcurso(int? concurso)
        {
            Lotofacil listConcursos = new Lotofacil();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Funcionarios", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Lotofacil lotofacil = new Lotofacil();
                    lotofacil.Consurso = Convert.ToInt32(rdr["Concurso"]);
                    lotofacil.Data = rdr["Data"].ToString();
                    lotofacil.Dezena01 = rdr["Dezena01"].ToString();
                    lotofacil.Dezena02 = rdr["Dezena02"].ToString();
                    lotofacil.Dezena03 = rdr["Dezena03"].ToString();
                    
                }
                con.Close();
            }
            return listConcursos;
        }
    }
}
