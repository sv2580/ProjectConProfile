using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    public class NacitaneData
    {
        public int _spektrum { get; set; }
        public double?[] _data { get; set; }
        public string _nazovSuboru { get; set; }


        public NacitaneData(int spektrum, double?[] data, string nazovSuboru)
        {
            this._spektrum = spektrum;
            this._data = data;
            this._nazovSuboru = nazovSuboru;
        }

    }
}
