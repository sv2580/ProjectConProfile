using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    internal class Projekt
    {
        public List<KoncentracnyProfil> _profily { get; set; }

        public Projekt () {
            _profily = new List<KoncentracnyProfil>();
        }
    }
}
