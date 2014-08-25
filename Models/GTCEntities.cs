using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace GenTestCase.Models
{
    public class GTCEntities : DbContext
    {
        public DbSet<Subsystem> Subsystems { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<TestPhase> TestPhases { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
    }
}