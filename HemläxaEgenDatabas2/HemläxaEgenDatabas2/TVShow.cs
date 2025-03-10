using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemläxaEgenDatabas2
{
    internal class TVShow
    {
        public int TVShowId { get; set; }
        public string Name { get; set; } = "";
        public string Network { get; set; } = "";
        public TVShow(string name, string network)
        {
            Name = name;
            Network = network;
        }

        public override string? ToString()
        {
            return $"Show: {Name} on {Network} (#{TVShowId})";
        }
    }
}
