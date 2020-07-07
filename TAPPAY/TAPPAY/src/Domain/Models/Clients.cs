using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPPAY.src.Domain.Models
{
    public class Clients : Identifier
    {
        public string name { get; set; }
        public string TAG { get; set; }
        public string phone { get; set; }
        public string beers { get; set; }
    }
}
