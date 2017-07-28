using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart7Builder.Models
{
    [Table("karts")]
    public class Kart
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string userId { get; set; }
        public int characterId { get; set; }
        public int bodyId { get; set; }
        public int tireId { get; set; }
        public int gliderId { get; set; }

        public virtual Character character { get; set; }
        public virtual Body body { get; set; }
        public virtual Tire tire { get; set; }
        public virtual Glider glider { get; set; }
    }
}
