using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    internal class NasobeneData 
    {
        public double _faktor { get; set; }
        public List<double> _nasobeneData { get; set; }
        public NacitaneData _povodneData { get; set; }

        public NasobeneData(double faktor, NacitaneData nacitaneData)
        {
            this._faktor = faktor;
            this._povodneData = nacitaneData;
            this._nasobeneData = new List<double>();
            for (int i = 0; i < _povodneData._data.Count; i++)
            {
                _nasobeneData.Add(_povodneData._data[i] * faktor);
            }
        }

        
    }
}
