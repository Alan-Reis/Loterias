using System.ComponentModel.DataAnnotations;

namespace LLotofacil.Models
{
    public class ApostaConcurso
    {
        [Key]
        public int ApostaConcursoID { get; set; }
        public int ConcursoID { get; set; }
        public int ApostasID { get; set; }

        public LotofacilAposta Aposta { get; set; }
        public LotofacilConcurso Concurso { get; set; }
    }
}