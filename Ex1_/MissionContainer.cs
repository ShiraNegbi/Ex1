using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        private Dictionary<string, Func<double,double>> dictionary;

        public FunctionsContainer()
        {
            this.dictionary = new Dictionary<string, Func<double, double>>();
        }

        public ICollection<string> getAllMissions()
        {
            return dictionary.Keys;
        }

        // Define the indexer to allow client code to use [] notation.
        public Func<double, double> this[string str]
        {
            get
            {
                if (!this.dictionary.ContainsKey(str))
                {
                    this.dictionary[str] = val => val;
                }
                return this.dictionary[str];
            }
            set { this.dictionary[str] = value; }
        }
    }
}
