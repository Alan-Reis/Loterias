using LLotofacil.Models;
using LLotofacil.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LLotofacil.Repository
{
    public class ConcursoRepository : IConcurso
    {
        private LotericaDbContext db;
        public ConcursoRepository(LotericaDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<LotofacilConcurso> GetConcursos => db.LotofacilConcursos;

        public void Add(LotofacilConcurso _LotofacilConcurso)
        {
            db.LotofacilConcursos.Add(_LotofacilConcurso);
            db.SaveChanges();
        }

        public LotofacilConcurso GetConcurso(int Id)
        {
            LotofacilConcurso dbEntity = db.LotofacilConcursos.Find(Id);
            return dbEntity;
        }

        public void Remove(int Id)
        {
            LotofacilConcurso dbEntity = db.LotofacilConcursos.Find(Id);
            db.LotofacilConcursos.Remove(dbEntity);
        }
    }
}
