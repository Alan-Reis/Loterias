using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Models
{
    public class LotofacilAposta
    {
        [Key]
        public int ApostaID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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
        public string Valor { get; set; }
        public string Pontuacao { get; set; }
        public string Ganho { get; set; }

        public ICollection<ApostaConcurso> ApostasConcursos { get; set; } 
    }
}
