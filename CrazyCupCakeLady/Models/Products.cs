using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int HowManySold { get; set; }
    }
}
