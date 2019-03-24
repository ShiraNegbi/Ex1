using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        // implement constructors and funcs
        // implement interface finctions
        private Func<double, double> Func { get; set; }
        public string Name { get; }
        public string Type { get; }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            return this.Func(value);
        }

        public SingleMission(Func<double, double> func, String name)
        {
            this.Type = "Single";
            this.Func = func;
            this.Name = name;
        }
    }
}
