using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Models
{
    public class DirectMessageModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int SendId { get; set; }
        public int RecId { get; set; }
        public DateTime Date { get; set; }
    }
}
