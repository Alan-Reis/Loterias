﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loterica.Data
{
    class DBLotericaContext : DbContext
    {
        public DbSet<Concurso> Concursos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0H4J542\SQLEXPRESS;Initial Catalog=DBLoterica;Integrated Security=True");
        }
    }
}
