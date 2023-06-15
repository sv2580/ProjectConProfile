using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    public class Projekt
    {
        public List<KoncentracnyProfil> _profily { get; set; }
        public string _nazovProjektu { get; set; }

        public Projekt (string nazov = null)
        {
            _profily = new List<KoncentracnyProfil>();
            _nazovProjektu = nazov;
        }
    }
}
