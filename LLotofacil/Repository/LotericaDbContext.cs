using LLotofacil.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Repository
{
    public class LotericaDbContext : DbContext
    {
        public LotericaDbContext(DbContextOptions<LotericaDbContext>options) : base (options)
        {

        }
        public DbSet<LotofacilConcurso> LotofacilConcursos { get; set; }
        public DbSet<LotofacilAposta> LotofacilApostas { get; set; }
    }
}
