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
        public List<double> _nasobeneData { get; set; }

        public NasobeneData(double faktor)
        {
            this._faktor = faktor;
            this._nasobeneData = new List<double>();
        }

        public void nasobData(NacitaneData nacitaneData)
        {
            for (int i = 0; i < nacitaneData._data.Count; i++)
            {
                _nasobeneData.Add(nacitaneData._data[i] * _faktor);
            }
        }

        
    }
}
