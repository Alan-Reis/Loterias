using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Models
{
    public class LotofacilAposta : LotofacilConcurso
    {
        [Key]
        public int ApostaID { get; set; }
        public string Valor { get; set; }
        public string Pontuacao { get; set; }
        public string Ganho { get; set; }

        public ICollection<ApostaConcurso> ApostasConcursos { get; set; } 
    }
}
