using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartMedChallenge.Models;

namespace SmartMedChallenge
{
    public class SmartMedContext : DbContext
    {
        public DbSet<Medication> Medication { get; set; }

        public string DbPath { get; }

        public SmartMedContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Medications.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
