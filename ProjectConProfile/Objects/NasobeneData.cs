using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    public class NasobeneData 
    {
        public double _faktor { get; set; }
        public double?[] _nasobeneData { get; set; }
        public string _nazovSuboru { get; set; }

        public NasobeneData(double faktor)
        {
            this._faktor = faktor;
        }

        public void nasobData(NacitaneData nacitaneData)
        {
            this._nazovSuboru = nacitaneData._nazovSuboru;
            this._nasobeneData = new double?[nacitaneData._data.Length];

            for (int i = 0; i < nacitaneData._data.Length; i++)
            {
                if (nacitaneData._data[i].HasValue)
                    _nasobeneData[i] = nacitaneData._data[i].Value * _faktor;
                else
                    _nasobeneData[i] = null;
            }
        }

        
    }
}
