using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GenTestCase.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<GTCEntities>
    {
        protected override void Seed(GTCEntities context)
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

            var equipments = new List<Equipment>
            {
                new Equipment { Name = "TRIU" },
                new Equipment { Name = "AMP" },
                new Equipment { Name = "TEL" },
                new Equipment { Name = "CSW" },
            };

            var phases = new List<TestPhase>
            {
                new TestPhase { Name = "FAI" },
                new TestPhase { Name = "POC" },
                new TestPhase { Name = "HFAT" },
                new TestPhase { Name = "IFAT" },
            };

            new List<TestCase>
            {
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
                new TestCase { Subsystem = subsystems.Single(s => s.Name == "RAD"), Equipment = equipments.Single(e => e.Name == "TRIU"), TestPhase = phases.Single(p => p.Name == "IFAT")},
            }.ForEach(a => context.TestCases.Add(a));

            equipments.ForEach(e => context.Equipments.Add(e));
            subsystems.ForEach(s => context.Subsystems.Add(s));
            phases.ForEach(p => context.TestPhases.Add(p));
        }
    }
}