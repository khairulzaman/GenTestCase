using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GenTestCase.Models
{
    public class Subsystem
    {
        public int SubsystemId { get; set; }
        [MaxLength(6)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}