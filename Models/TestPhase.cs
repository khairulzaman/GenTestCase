using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GenTestCase.Models
{
    public class TestPhase
    {
        public int TestPhaseId { get; set; }

        [MaxLength(4)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}