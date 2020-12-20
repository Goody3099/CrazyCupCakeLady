using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Models
{
    public class ChatModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
    }
}
