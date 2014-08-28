using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GenTestCase.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        [MaxLength(4)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}