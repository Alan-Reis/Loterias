using LLotofacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Services
{
    public interface IConcurso
    {
       IEnumerable<LotofacilConcurso> GetConcursos { get; }
        LotofacilConcurso GetConcurso(int Id);
        void Add(LotofacilConcurso _LotofacilConcurso);
        void Remove(int Id);
    }
}
