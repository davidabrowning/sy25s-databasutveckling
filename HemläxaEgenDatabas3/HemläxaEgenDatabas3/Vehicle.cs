using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemläxaEgenDatabas3
{
    internal abstract class Vehicle
    {
        public int Id { get; set; } = 0;
        public string Model { get; set; } = "";
        public int Year { get; set; } = 0;
        public string Color { get; set; } = "";
    }
}
