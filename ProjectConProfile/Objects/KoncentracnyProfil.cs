using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    public class KoncentracnyProfil
    {
        public List<NacitaneData> _nacitaneData { get; set; }
        public List<NasobeneData> _nasobeneData { get; set; }
        public List<double> _excitacia { get; set; }
        public List<double> _profil { get; set; }
        //TO-DO statistiky
        public KoncentracnyProfil(List<NacitaneData> nacitaneData, List<double> excitacia)
        {
            _nacitaneData = nacitaneData;
            _excitacia = excitacia;
            _profil = new List<double>();       
        }

        public void vytvoritProfil()
        {
            if(_nasobeneData.Count > 0) {
                for (int i = 0; i < _nasobeneData[0]._nasobeneData.Count; i++)
                {
                    double max = -1;
                    for (int j = 0; j < _nasobeneData.Count; j++)
                    {
                        double pom = _nasobeneData[j]._nasobeneData[i];
                        if (pom > max)
                            max = pom;
                    }
                    _profil.Add(max);
                }
            }
        }
    }
}
