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
        public DbSet<ApostaConcurso> ApostasConcursos { get; set; }

        //para renomear as tabelas incluir o código abaixo
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LotofacilConcurso>().ToTable("LotofacilConcurso");
            modelBuilder.Entity<LotofacilAposta>().ToTable("LotofacilAposta");
            modelBuilder.Entity<ApostaConcurso>().ToTable("ApostaConcurso");
        }*/
    }
}
