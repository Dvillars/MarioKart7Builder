using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart7Builder.Models
{
    [Table("bodys")]
    public class Body
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int landSpeed { get; set; }
        public int waterSpeed { get; set; }
        public int airSpeed { get; set; }
        public int acceleration { get; set; }
        public int weight { get; set; }
        public int landHandling { get; set; }
        public int watrHandling { get; set; }
        public int airHandling { get; set; }
        public int offRoad { get; set; }
        public int miniTurbo { get; set; }
        public int stabiliy { get; set; }
        public int drift { get; set; }
    }
}
