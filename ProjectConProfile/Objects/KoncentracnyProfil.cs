﻿using System;
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
        public double[] _profil { get; set; }
        public string _nazovPriecinku { get; set; }

       
        public double _maxValueN { get; set; }
        public double _minValueN { get; set; }

        public double _standardDeviationN { get; set; }


        public KoncentracnyProfil(List<NacitaneData> nacitaneData, List<double> excitacia, string nazovPriecinku)
        {
            _nacitaneData = nacitaneData;
            _excitacia = excitacia;
            _nasobeneData = new List<NasobeneData>();
            _nazovPriecinku = nazovPriecinku;
            
            
            _maxValueN = new double();
            _minValueN = new double();
            _standardDeviationN = new double();
        }

        public void vytvoritProfil()
        {
            _profil = new double[_excitacia.Count];

            if (_nasobeneData.Count > 0) {
                int index = 0;
                for (int i = 0; i < _excitacia.Count; i++)
                {
                    double max = -1;
                    for (int j = 0; j < _nasobeneData.Count; j++)
                    {
                        if (_nasobeneData[j]._nasobeneData[i].HasValue)
                        {
                            double pom = _nasobeneData[j]._nasobeneData[i].Value;
                            if (pom > max)
                                max = pom;
                        }
                     
                    }
                    _profil[index] = max;
                    index++;
                }
            }
        }
    }
}
