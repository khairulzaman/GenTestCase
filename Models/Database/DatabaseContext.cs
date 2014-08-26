using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace GenTestCase.Models
{
    public class DatabaseContext : DbContext
    {
        public static string ConnectionStringName = "GTCEntities";

        public DatabaseContext() : base(ConnectionStringName) { }

        public DbSet<Subsystem> Subsystems { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<TestPhase> TestPhases { get; set; }
        public DbSet<TestCase> TestCases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        // Seeds database with data
        public void Seed(DatabaseContext context)
        {
            var subsystems = new List<Subsystem> 
            {
                new Subsystem { Name = "BTN" },
                new Subsystem { Name = "CCTV" },
                new Subsystem { Name = "RAD" },
                new Subsystem { Name = "CLK" },
                new Subsystem { Name = "TEL" },
                new Subsystem { Name = "WDCS" },
                new Subsystem { Name = "PAS" },
                new Subsystem { Name = "PIDS" },
                new Subsystem { Name = "PAPIDS" },
                new Subsystem { Name = "TNMS" },
                new Subsystem { Name = "UPS" }
            };

            subsystems.ForEach(a => context.Subsystems.Add(a));

            context.SaveChanges();
        }

        // Debug: DropCreate -> Seed | Live: Create -> Seed
        static DatabaseContext()
        {
            #if DEBUG
            Database.SetInitializer<DatabaseContext>(new DropCreateAlwaysInitializer());
            #else
            Database.SetInitializer<DatabaseContext>(new CreateInitializer());
            #endif
        }
    }
}