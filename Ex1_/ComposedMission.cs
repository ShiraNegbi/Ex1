using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        // implement constructors and funcs
        // implement interface finctions
        private List<Func<double, double>> Funcs;
        public string Name { get; }
        public string Type { get; }
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result = value;
            foreach (Func<double, double> f in this.Funcs)
            {
                result = f(result);
            }
            return result;
        }

        public ComposedMission(string name)
        {
            this.Type = "Composed";
            this.Name = name;
            this.Funcs = new List<Func<double, double>>();
        }

        public ComposedMission Add(Func<double, double> func)
        {
            this.Funcs.Add(func);
            return this;
        }
    }
}
