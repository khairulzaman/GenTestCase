using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace GenTestCase.Models
{
    public class TestCase
    {
        [ScaffoldColumn(false)]
        public int TestCaseId { get; set; }

        [DisplayName("Subsystem")]
        public int SubsystemId { get; set; }

        [DisplayName("Equipment")]
        public int EquipmentId { get; set; }

        [DisplayName("TestPhase")]
        public int TestPhaseId { get; set; }

        public string Number { 
            get { 
                return this.Subsystem.Name + "-" + this.Equipment.Name + "-" + this.TestPhase.Name + "-" + String.Format("{0:0000}", this.TestCaseId); 
            } 
        }

        public virtual Subsystem Subsystem { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual TestPhase TestPhase { get; set; }
    }
}