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

        #region //Retorna todos os concursos (criar paginação e campo de pesquisa)
        public IEnumerable<Lotofacil> GetAllConcursos()
        {
            List<Lotofacil> concursos = new List<Lotofacil>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbo].[LotofacilConcursos] ORDER BY ConcursoID DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Lotofacil lotofacil = new Lotofacil();
                    lotofacil.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                    lotofacil.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                    lotofacil.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                    lotofacil.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                    lotofacil.Dezena_01 = Convert.ToInt32(rdr["Dezena_01"].ToString());
                    lotofacil.Dezena_02 = Convert.ToInt32(rdr["Dezena_02"].ToString());
                    lotofacil.Dezena_03 = Convert.ToInt32(rdr["Dezena_03"].ToString());
                    lotofacil.Dezena_04 = Convert.ToInt32(rdr["Dezena_04"].ToString());
                    lotofacil.Dezena_05 = Convert.ToInt32(rdr["Dezena_05"].ToString());
                    lotofacil.Dezena_06 = Convert.ToInt32(rdr["Dezena_06"].ToString());
                    lotofacil.Dezena_07 = Convert.ToInt32(rdr["Dezena_07"].ToString());
                    lotofacil.Dezena_08 = Convert.ToInt32(rdr["Dezena_08"].ToString());
                    lotofacil.Dezena_09 = Convert.ToInt32(rdr["Dezena_09"].ToString());
                    lotofacil.Dezena_10 = Convert.ToInt32(rdr["Dezena_10"].ToString());
                    lotofacil.Dezena_11 = Convert.ToInt32(rdr["Dezena_11"].ToString());
                    lotofacil.Dezena_12 = Convert.ToInt32(rdr["Dezena_12"].ToString());
                    lotofacil.Dezena_13 = Convert.ToInt32(rdr["Dezena_13"].ToString());
                    lotofacil.Dezena_14 = Convert.ToInt32(rdr["Dezena_14"].ToString());
                    lotofacil.Dezena_15 = Convert.ToInt32(rdr["Dezena_15"].ToString());
                    lotofacil.Arrecadacao = rdr["Arrecadacao"].ToString();
                    lotofacil.Ganhadores = Convert.ToInt32(rdr["Ganhadores"].ToString());
                    concursos.Add(lotofacil);
                }
                con.Close();
            }
            return concursos;
        }
        #endregion

        #region //Utilizado pelo simulador para verificar as dezenas
        public IEnumerable<Lotofacil> GetPontos(int? Dezena_01, int? Dezena_02, int? Dezena_03, int? Dezena_04, int? Dezena_05,
                                                int? Dezena_06, int? Dezena_07, int? Dezena_08, int? Dezena_09, int? Dezena_10,
                                                int? Dezena_11, int? Dezena_12, int? Dezena_13, int? Dezena_14, int? Dezena_15)

        {
            List<Lotofacil> concursos = new List<Lotofacil>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PONTOS(" + Dezena_01 + "," + Dezena_02 + "," + Dezena_03 + "," + Dezena_04 + "," + Dezena_05 + "," + Dezena_06 + "," +
                    "" + Dezena_07 + "," + Dezena_08 + "," + Dezena_09 + "," + Dezena_10 + "," + Dezena_11 + "," + Dezena_12 + "," + Dezena_13 + "," + Dezena_14 + "," + Dezena_15 + ")ORDER BY ConcursoID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Lotofacil lotofacil = new Lotofacil();
                        lotofacil.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                        lotofacil.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                        lotofacil.ConcursoID = Convert.ToInt32(rdr["ConcursoID"]);
                        lotofacil.Data = String.Format("{0:dd/MM/yyyy}", rdr["Data"]);
                        lotofacil.Dezena_01 = Convert.ToInt32(rdr["Dezena_01"].ToString());
                        lotofacil.Dezena_02 = Convert.ToInt32(rdr["Dezena_02"].ToString());
                        lotofacil.Dezena_03 = Convert.ToInt32(rdr["Dezena_03"].ToString());
                        lotofacil.Dezena_04 = Convert.ToInt32(rdr["Dezena_04"].ToString());
                        lotofacil.Dezena_05 = Convert.ToInt32(rdr["Dezena_05"].ToString());
                        lotofacil.Dezena_06 = Convert.ToInt32(rdr["Dezena_06"].ToString());
                        lotofacil.Dezena_07 = Convert.ToInt32(rdr["Dezena_07"].ToString());
                        lotofacil.Dezena_08 = Convert.ToInt32(rdr["Dezena_08"].ToString());
                        lotofacil.Dezena_09 = Convert.ToInt32(rdr["Dezena_09"].ToString());
                        lotofacil.Dezena_10 = Convert.ToInt32(rdr["Dezena_10"].ToString());
                        lotofacil.Dezena_11 = Convert.ToInt32(rdr["Dezena_11"].ToString());
                        lotofacil.Dezena_12 = Convert.ToInt32(rdr["Dezena_12"].ToString());
                        lotofacil.Dezena_13 = Convert.ToInt32(rdr["Dezena_13"].ToString());
                        lotofacil.Dezena_14 = Convert.ToInt32(rdr["Dezena_14"].ToString());
                        lotofacil.Dezena_15 = Convert.ToInt32(rdr["Dezena_15"].ToString());

                        #region //VERIFICAR TOTAL DE PONTOS
                        if (
                            Dezena_01 == lotofacil.Dezena_01 ||
                            Dezena_01 == lotofacil.Dezena_02 ||
                            Dezena_01 == lotofacil.Dezena_03 ||
                            Dezena_01 == lotofacil.Dezena_04 ||
                            Dezena_01 == lotofacil.Dezena_05 ||
                            Dezena_01 == lotofacil.Dezena_06 ||
                            Dezena_01 == lotofacil.Dezena_07
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                              Dezena_02 == lotofacil.Dezena_01 ||
                              Dezena_02 == lotofacil.Dezena_02 ||
                              Dezena_02 == lotofacil.Dezena_03 ||
                              Dezena_02 == lotofacil.Dezena_04 ||
                              Dezena_02 == lotofacil.Dezena_05 ||
                              Dezena_02 == lotofacil.Dezena_06 ||
                              Dezena_02 == lotofacil.Dezena_07 ||
                              Dezena_02 == lotofacil.Dezena_08 ||
                              Dezena_02 == lotofacil.Dezena_09
                              )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                              Dezena_03 == lotofacil.Dezena_01 ||
                              Dezena_03 == lotofacil.Dezena_02 ||
                              Dezena_03 == lotofacil.Dezena_03 ||
                              Dezena_03 == lotofacil.Dezena_04 ||
                              Dezena_03 == lotofacil.Dezena_05 ||
                              Dezena_03 == lotofacil.Dezena_06 ||
                              Dezena_03 == lotofacil.Dezena_07 ||
                              Dezena_03 == lotofacil.Dezena_08 ||
                              Dezena_03 == lotofacil.Dezena_09 ||
                              Dezena_03 == lotofacil.Dezena_10 ||
                              Dezena_03 == lotofacil.Dezena_11
                             )
                        {
                            lotofacil.Total = +1;
                        }

                        if (
                           Dezena_04 == lotofacil.Dezena_01 ||
                           Dezena_04 == lotofacil.Dezena_02 ||
                           Dezena_04 == lotofacil.Dezena_03 ||
                           Dezena_04 == lotofacil.Dezena_04 ||
                           Dezena_04 == lotofacil.Dezena_05 ||
                           Dezena_04 == lotofacil.Dezena_06 ||
                           Dezena_04 == lotofacil.Dezena_07 ||
                           Dezena_04 == lotofacil.Dezena_08 ||
                           Dezena_04 == lotofacil.Dezena_09 ||
                           Dezena_04 == lotofacil.Dezena_10 ||
                           Dezena_04 == lotofacil.Dezena_11 ||
                           Dezena_04 == lotofacil.Dezena_12 ||
                           Dezena_04 == lotofacil.Dezena_13
                           )
                        {
                            lotofacil.Total = +1;
                        }

                        if (
                            Dezena_05 == lotofacil.Dezena_01 ||
                            Dezena_05 == lotofacil.Dezena_02 ||
                            Dezena_05 == lotofacil.Dezena_03 ||
                            Dezena_05 == lotofacil.Dezena_04 ||
                            Dezena_05 == lotofacil.Dezena_05 ||
                            Dezena_05 == lotofacil.Dezena_06 ||
                            Dezena_05 == lotofacil.Dezena_07 ||
                            Dezena_05 == lotofacil.Dezena_08 ||
                            Dezena_05 == lotofacil.Dezena_09 ||
                            Dezena_05 == lotofacil.Dezena_10 ||
                            Dezena_05 == lotofacil.Dezena_11 ||
                            Dezena_05 == lotofacil.Dezena_12 ||
                            Dezena_05 == lotofacil.Dezena_13 ||
                            Dezena_05 == lotofacil.Dezena_14
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_06 == lotofacil.Dezena_01 ||
                            Dezena_06 == lotofacil.Dezena_02 ||
                            Dezena_06 == lotofacil.Dezena_03 ||
                            Dezena_06 == lotofacil.Dezena_04 ||
                            Dezena_06 == lotofacil.Dezena_05 ||
                            Dezena_06 == lotofacil.Dezena_06 ||
                            Dezena_06 == lotofacil.Dezena_07 ||
                            Dezena_06 == lotofacil.Dezena_08 ||
                            Dezena_06 == lotofacil.Dezena_09 ||
                            Dezena_06 == lotofacil.Dezena_10 ||
                            Dezena_06 == lotofacil.Dezena_11 ||
                            Dezena_06 == lotofacil.Dezena_12 ||
                            Dezena_06 == lotofacil.Dezena_13 ||
                            Dezena_06 == lotofacil.Dezena_14 ||
                            Dezena_06 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_07 == lotofacil.Dezena_01 ||
                            Dezena_07 == lotofacil.Dezena_02 ||
                            Dezena_07 == lotofacil.Dezena_03 ||
                            Dezena_07 == lotofacil.Dezena_04 ||
                            Dezena_07 == lotofacil.Dezena_05 ||
                            Dezena_07 == lotofacil.Dezena_06 ||
                            Dezena_07 == lotofacil.Dezena_07 ||
                            Dezena_07 == lotofacil.Dezena_08 ||
                            Dezena_07 == lotofacil.Dezena_09 ||
                            Dezena_07 == lotofacil.Dezena_10 ||
                            Dezena_07 == lotofacil.Dezena_11 ||
                            Dezena_07 == lotofacil.Dezena_12 ||
                            Dezena_07 == lotofacil.Dezena_13 ||
                            Dezena_07 == lotofacil.Dezena_14 ||
                            Dezena_07 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_08 == lotofacil.Dezena_01 ||
                            Dezena_08 == lotofacil.Dezena_02 ||
                            Dezena_08 == lotofacil.Dezena_03 ||
                            Dezena_08 == lotofacil.Dezena_04 ||
                            Dezena_08 == lotofacil.Dezena_05 ||
                            Dezena_08 == lotofacil.Dezena_06 ||
                            Dezena_08 == lotofacil.Dezena_07 ||
                            Dezena_08 == lotofacil.Dezena_08 ||
                            Dezena_08 == lotofacil.Dezena_09 ||
                            Dezena_08 == lotofacil.Dezena_10 ||
                            Dezena_08 == lotofacil.Dezena_11 ||
                            Dezena_08 == lotofacil.Dezena_12 ||
                            Dezena_08 == lotofacil.Dezena_13 ||
                            Dezena_08 == lotofacil.Dezena_14 ||
                            Dezena_08 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_09 == lotofacil.Dezena_02 ||
                            Dezena_09 == lotofacil.Dezena_03 ||
                            Dezena_09 == lotofacil.Dezena_04 ||
                            Dezena_09 == lotofacil.Dezena_05 ||
                            Dezena_09 == lotofacil.Dezena_06 ||
                            Dezena_09 == lotofacil.Dezena_07 ||
                            Dezena_09 == lotofacil.Dezena_08 ||
                            Dezena_09 == lotofacil.Dezena_09 ||
                            Dezena_09 == lotofacil.Dezena_10 ||
                            Dezena_09 == lotofacil.Dezena_11 ||
                            Dezena_09 == lotofacil.Dezena_12 ||
                            Dezena_09 == lotofacil.Dezena_13 ||
                            Dezena_09 == lotofacil.Dezena_14 ||
                            Dezena_09 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_10 == lotofacil.Dezena_02 ||
                            Dezena_10 == lotofacil.Dezena_03 ||
                            Dezena_10 == lotofacil.Dezena_04 ||
                            Dezena_10 == lotofacil.Dezena_05 ||
                            Dezena_10 == lotofacil.Dezena_06 ||
                            Dezena_10 == lotofacil.Dezena_07 ||
                            Dezena_10 == lotofacil.Dezena_08 ||
                            Dezena_10 == lotofacil.Dezena_09 ||
                            Dezena_10 == lotofacil.Dezena_10 ||
                            Dezena_10 == lotofacil.Dezena_11 ||
                            Dezena_10 == lotofacil.Dezena_12 ||
                            Dezena_10 == lotofacil.Dezena_13 ||
                            Dezena_10 == lotofacil.Dezena_14 ||
                            Dezena_10 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_11 == lotofacil.Dezena_03 ||
                            Dezena_11 == lotofacil.Dezena_04 ||
                            Dezena_11 == lotofacil.Dezena_05 ||
                            Dezena_11 == lotofacil.Dezena_06 ||
                            Dezena_11 == lotofacil.Dezena_07 ||
                            Dezena_11 == lotofacil.Dezena_08 ||
                            Dezena_11 == lotofacil.Dezena_09 ||
                            Dezena_11 == lotofacil.Dezena_10 ||
                            Dezena_11 == lotofacil.Dezena_11 ||
                            Dezena_11 == lotofacil.Dezena_12 ||
                            Dezena_11 == lotofacil.Dezena_13 ||
                            Dezena_11 == lotofacil.Dezena_14 ||
                            Dezena_11 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_12 == lotofacil.Dezena_03 ||
                            Dezena_12 == lotofacil.Dezena_04 ||
                            Dezena_12 == lotofacil.Dezena_05 ||
                            Dezena_12 == lotofacil.Dezena_06 ||
                            Dezena_12 == lotofacil.Dezena_07 ||
                            Dezena_12 == lotofacil.Dezena_08 ||
                            Dezena_12 == lotofacil.Dezena_09 ||
                            Dezena_12 == lotofacil.Dezena_10 ||
                            Dezena_12 == lotofacil.Dezena_11 ||
                            Dezena_12 == lotofacil.Dezena_12 ||
                            Dezena_12 == lotofacil.Dezena_13 ||
                            Dezena_12 == lotofacil.Dezena_14 ||
                            Dezena_12 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_13 == lotofacil.Dezena_03 ||
                            Dezena_13 == lotofacil.Dezena_04 ||
                            Dezena_13 == lotofacil.Dezena_05 ||
                            Dezena_13 == lotofacil.Dezena_06 ||
                            Dezena_13 == lotofacil.Dezena_07 ||
                            Dezena_13 == lotofacil.Dezena_08 ||
                            Dezena_13 == lotofacil.Dezena_09 ||
                            Dezena_13 == lotofacil.Dezena_10 ||
                            Dezena_13 == lotofacil.Dezena_11 ||
                            Dezena_13 == lotofacil.Dezena_12 ||
                            Dezena_13 == lotofacil.Dezena_13 ||
                            Dezena_13 == lotofacil.Dezena_14 ||
                            Dezena_13 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_14 == lotofacil.Dezena_04 ||
                            Dezena_14 == lotofacil.Dezena_05 ||
                            Dezena_14 == lotofacil.Dezena_06 ||
                            Dezena_14 == lotofacil.Dezena_07 ||
                            Dezena_14 == lotofacil.Dezena_08 ||
                            Dezena_14 == lotofacil.Dezena_03 ||
                            Dezena_14 == lotofacil.Dezena_09 ||
                            Dezena_14 == lotofacil.Dezena_10 ||
                            Dezena_14 == lotofacil.Dezena_11 ||
                            Dezena_14 == lotofacil.Dezena_12 ||
                            Dezena_14 == lotofacil.Dezena_13 ||
                            Dezena_14 == lotofacil.Dezena_14 ||
                            Dezena_14 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        if (
                            Dezena_15 == lotofacil.Dezena_04 ||
                            Dezena_15 == lotofacil.Dezena_05 ||
                            Dezena_15 == lotofacil.Dezena_06 ||
                            Dezena_15 == lotofacil.Dezena_07 ||
                            Dezena_15 == lotofacil.Dezena_08 ||
                            Dezena_15 == lotofacil.Dezena_03 ||
                            Dezena_15 == lotofacil.Dezena_09 ||
                            Dezena_15 == lotofacil.Dezena_10 ||
                            Dezena_15 == lotofacil.Dezena_11 ||
                            Dezena_15 == lotofacil.Dezena_12 ||
                            Dezena_15 == lotofacil.Dezena_13 ||
                            Dezena_15 == lotofacil.Dezena_14 ||
                            Dezena_15 == lotofacil.Dezena_15
                            )
                        {
                            lotofacil.Total = +1;
                        }
                        #endregion

                        #region                       //Par ou ímpar
                        if (lotofacil.Dezena_01 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_02 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_03 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_04 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_05 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_06 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_07 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_08 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_09 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_10 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_11 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_12 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_13 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_14 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        if (lotofacil.Dezena_15 % 2 == 0)
                        {
                            lotofacil.TotalPar = +1;
                        }
                        else
                        {
                            lotofacil.TotalImpar = +1;
                        }
                        #endregion
                        
                        concursos.Add(lotofacil);
                    }
                }
                catch (Exception ex)
                {

                }



                con.Close();
            }
            return concursos;
        }
        #endregion


        #region//GetConcurso foi criado para atender ao SeleniumWebScrapting para setar o último concurso
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
                int count = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                return count;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        #endregion

        #region//Já esse GetConcurso é criado para a página de detalhes de cada concurso
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
                concurso.Dezena_01 = Convert.ToInt32(rdr["Dezena_01"].ToString());
                concurso.Dezena_02 = Convert.ToInt32(rdr["Dezena_02"].ToString());
                concurso.Dezena_03 = Convert.ToInt32(rdr["Dezena_03"].ToString());
                concurso.Dezena_04 = Convert.ToInt32(rdr["Dezena_04"].ToString());
                concurso.Dezena_05 = Convert.ToInt32(rdr["Dezena_05"].ToString());
                concurso.Dezena_06 = Convert.ToInt32(rdr["Dezena_06"].ToString());
                concurso.Dezena_07 = Convert.ToInt32(rdr["Dezena_07"].ToString());
                concurso.Dezena_08 = Convert.ToInt32(rdr["Dezena_08"].ToString());
                concurso.Dezena_09 = Convert.ToInt32(rdr["Dezena_09"].ToString());
                concurso.Dezena_10 = Convert.ToInt32(rdr["Dezena_10"].ToString());
                concurso.Dezena_11 = Convert.ToInt32(rdr["Dezena_11"].ToString());
                concurso.Dezena_12 = Convert.ToInt32(rdr["Dezena_12"].ToString());
                concurso.Dezena_13 = Convert.ToInt32(rdr["Dezena_13"].ToString());
                concurso.Dezena_14 = Convert.ToInt32(rdr["Dezena_14"].ToString());
                concurso.Dezena_15 = Convert.ToInt32(rdr["Dezena_15"].ToString());
                concurso.Arrecadacao = rdr["Arrecadacao"].ToString();
                concurso.Ganhadores = Convert.ToInt32(rdr["Ganhadores"].ToString());

                con.Close();
            }
            return concurso;
        }
        #endregion

        #region //Usado pelo WebScrapting para inserir os dados
        public void Inserir(int Consurso, string Data, int D1, int D2, int D3, int D4, int D5, int D6, int D7, int D8, int D9,
                            int D10, int D11, int D12, int D13, int D14, int D15, string Arrecadacao, int Ganhadores)
        {

            //definição da string de conexão
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7KH1TOI\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True");

            //definição do comando sql
            string sqlSet = "SET IDENTITY_INSERT [LotofacilConcursos] ON";
            string sql = "INSERT INTO LotofacilConcursos(ConcursoID, Data, Dezena_01, Dezena_02, Dezena_03, Dezena_04, Dezena_05, Dezena_06, Dezena_07, Dezena_08, Dezena_09, Dezena_10, Dezena_11, Dezena_12, Dezena_13, Dezena_14, Dezena_15, Arrecadacao, Ganhadores) " +
            "Values(@Concurso, @Data, @Dezena01, @Dezena02, @Dezena03, @Dezena04, @Dezena05, @Dezena06, @Dezena07, @Dezena08, @Dezena09, @Dezena10, @Dezena11, @Dezena12, @Dezena13, @Dezena14, @Dezena15, @Arrecadacao, @Ganhadores)";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand cmd1 = new SqlCommand(sqlSet, con);
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
                Console.WriteLine("Inserindo concurso de número:" + Consurso);
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
        #endregion
    }
}
