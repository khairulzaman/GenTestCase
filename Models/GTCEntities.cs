using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace GenTestCase.Models
{
    public class GTCEntities : DbContext
    {
        public static string ConnectionStringName = "GTCEntities";

        public GTCEntities() : base(ConnectionStringName) { }

        public DbSet<Subsystem> Subsystems { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<TestPhase> TestPhases { get; set; }
        public DbSet<TestCase> TestCases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GTCEntities, Configuration>());
            base.OnModelCreating(modelBuilder);
        }
    }
}