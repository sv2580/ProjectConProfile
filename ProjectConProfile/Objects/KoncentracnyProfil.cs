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
        public string _nazovPriecinku { get; set; }
        public int _maxPocet { get; set; } //ak by sa stalo, že niektorý súbor má menší počet dát

        //TO-DO statistiky
        public KoncentracnyProfil(List<NacitaneData> nacitaneData, List<double> excitacia, string nazovPriecinku)
        {
            _nacitaneData = nacitaneData;
            _excitacia = excitacia;
            _profil = new List<double>();
            _nasobeneData = new List<NasobeneData>();
            foreach(NacitaneData nacitane in nacitaneData)
            {
                if (nacitane._data.Count > _maxPocet)
                    _maxPocet = nacitane._data.Count;
            }

            _nazovPriecinku = nazovPriecinku;
        }

        public void vytvoritProfil()
        {
            if(_nasobeneData.Count > 0) {
                for (int i = 0; i < _maxPocet; i++)
                {
                    double max = -1;
                    for (int j = 0; j < _nasobeneData.Count; j++)
                    {
                        if(_nasobeneData[j]._nasobeneData.Count > i) { 
                            double pom = _nasobeneData[j]._nasobeneData[i];
                            if (pom > max)
                                max = pom;
                        }
                    }
                    _profil.Add(max);
                }
            }
        }
    }
}
