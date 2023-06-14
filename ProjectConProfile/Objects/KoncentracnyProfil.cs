using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    internal class KoncentracnyProfil
    {
        public List<NasobeneData> _data { get; set; }
        public List<double> _excitacia { get; set; }
        public List<double> _profil { get; set; }
        //TO-DO statistiky
        public KoncentracnyProfil(List<NasobeneData> data, List<double> excitacia)
        {
            _data = data;
            _excitacia = excitacia;

            _profil = new List<double>();
            for (int i = 0; i < _data[0]._nasobeneData.Count; i++)
            {
                double max = -1;
                for (int j = 0; j < _data.Count; j++)
                {
                    double pom = _data[j]._nasobeneData[i];
                    if (pom > max)
                        max = pom;
                }
                _profil.Add(max);
            }
        }

        
    }
}
