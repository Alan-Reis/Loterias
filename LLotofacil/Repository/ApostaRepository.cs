using LLotofacil.Models;
using LLotofacil.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Repository
{
    public class ApostaRepository : IAposta
    {
        private LotericaDbContext db;

        public ApostaRepository(LotericaDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<LotofacilAposta> GetApostas => db.LotofacilApostas;

        public void Add(LotofacilAposta _LotofacilAposta)
        {
            db.LotofacilApostas.Add(_LotofacilAposta);
            db.SaveChanges();
        }

        public LotofacilAposta GetAposta(int Id)
        {
            LotofacilAposta dbEntity = db.LotofacilApostas.Find(Id);
            return dbEntity;
        }

        public void Remove(int Id)
        {
            LotofacilAposta dbEntity = db.LotofacilApostas.Find(Id);
            db.LotofacilApostas.Remove(dbEntity);
        }
    }
}
