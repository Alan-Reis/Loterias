using LLotofacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Services
{
    public interface IAposta
    {
        IEnumerable<LotofacilAposta> GetApostas { get; }
        LotofacilAposta GetAposta(int Id);
        void Add(LotofacilAposta _LotofacilAposta);
        void Remove(int Id);
    }
}
