using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LLotofacil.Models
{
    public class LotofacilConcurso
    {
        //Esse atributo permite inserir a PK para o curso em vez de fazer com que o banco de dados o gere.
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ConcursoID { get; set; }
        public DateTime Data { get; set; }
        public string Dezena_01 { get; set; }
        public string Dezena_02 { get; set; }
        public string Dezena_03 { get; set; }
        public string Dezena_04 { get; set; }
        public string Dezena_05 { get; set; }
        public string Dezena_06 { get; set; }
        public string Dezena_07 { get; set; }
        public string Dezena_08 { get; set; }
        public string Dezena_09 { get; set; }
        public string Dezena_10 { get; set; }
        public string Dezena_11 { get; set; }
        public string Dezena_12 { get; set; }
        public string Dezena_13 { get; set; }
        public string Dezena_14 { get; set; }
        public string Dezena_15 { get; set; }
        public string Arrecadacao { get; set; }
        public string Ganhadores { get; set; }

        public ICollection<ApostaConcurso> ApostasConcursos { get; set; }
    }
}
