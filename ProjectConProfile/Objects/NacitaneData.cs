using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    internal class NacitaneData
    {
        public int _spektrum { get; set; }
        public List<double> _data { get; set; }

        public NacitaneData(int spektrum, List<double> data) {
            this._spektrum = spektrum;
            this._data = data;   
        }   
        
    }
}
