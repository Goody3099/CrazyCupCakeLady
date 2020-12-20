using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Models
{
    public class CartProducts
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quant { get; set; }
        public DateTime Due { get; set; }
    }
}
