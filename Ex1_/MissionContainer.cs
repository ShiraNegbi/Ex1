using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        // public delegate double DoubleToDouble(double x);
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
            get { return this.dictionary[str]; }
            set { this.dictionary[str] = value; }
        }
        //a dictionary from string to function double func(double d) with delegate, syntax from google
        // a pointer to a func
        // indexer - syntax from google
        // func printavailable
        // constructor
    }
}
