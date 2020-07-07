using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Domain.Interfaces;

namespace TAPPAY.src.Domain.Models
{
    public class Identifier : IIndentifier
    {
        public int id { get; set; }
    }
}
