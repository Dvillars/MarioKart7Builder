using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart7Builder.Models
{
    [Table("gliders")]
    public class Glider
    {
        public Glider()
        {
            this.Karts = new HashSet<Kart>();
        }
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float landSpeed { get; set; }
        public float waterSpeed { get; set; }
        public float airSpeed { get; set; }
        public float acceleration { get; set; }
        public float weight { get; set; }
        public float landHandling { get; set; }
        public float watrHandling { get; set; }
        public float airHandling { get; set; }
        public float offRoad { get; set; }
        public float miniTurbo { get; set; }
        public float stabiliy { get; set; }
        public float drift { get; set; }
        public virtual ICollection<Kart> Karts { get; set; }
    }
}
