using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    //pomocna trieda pre zaradenie viacerych hodnot jednemu klucu vyuzijem iba pri faktoroch
    //a spektrach zo suboru, pretoze chcem ukladat vzdy nove zadane spektra a mozno ak by sa zmenili?
    //nech maju na vyber asi 
    public class MultimapDictionary
    {
        public Dictionary<int, List<double>> multimap { get; set; }

        public MultimapDictionary()
        {
            multimap = new Dictionary<int, List<double>>();
        }

        public void AddValue(int key, double value)
        {
            if (!multimap.TryGetValue(key, out List<double> values))
            {
                values = new List<double>();
                multimap.Add(key, values);
            }

            values.Add(value);
        }

       public List<double> GetValue(int key)
        {
            if (multimap.TryGetValue(key, out List<double> values))
            {
                return values;
            }

            return null;
        }
    }
}
