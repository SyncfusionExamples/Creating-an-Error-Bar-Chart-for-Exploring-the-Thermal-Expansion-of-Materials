using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorBarSample
{
    public class ThermalExpansionModel
    {
        public string MaterialName { get; set; }
        public double Coefficient { get; set; }
        public double ErrorValue { get; set; }
        public double HighErrorValue { get; set; }
        public double LowErrorValue { get; set; }

        public ThermalExpansionModel(string materialName, double lowError, double highError)
        {
            MaterialName = materialName;
            HighErrorValue = highError;
            LowErrorValue = lowError;
            Coefficient = (highError + lowError) / 2;
            ErrorValue = (highError - lowError) / 2;
        }
    }
}
