using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorBarBlog
{
    public class MaterialViewModel
    {
        public ObservableCollection<MaterialModel> ThermalExpansion { get; set; }

        public MaterialViewModel()
        {
            ThermalExpansion = new ObservableCollection<MaterialModel>()
            {
                new MaterialModel("Erbium", 8.2, 3.8, 12, 5.2),
                new MaterialModel("Samarium", 8.15, 2.85, 11, 5.3),
                new MaterialModel("Yttrium", 7.15, 3.85, 11, 3.3),
                new MaterialModel("Carbide", 6.45, 2.95, 9.4, 3.5),
                new MaterialModel("Tin", 14.6, 5.4, 20, 9.2),
                new MaterialModel("Holmium", 7.45, 3.55, 11, 3.9),
                new MaterialModel("Thulium", 8.45, 3.55, 12, 4.9),
                new MaterialModel("Scandium", 6.35, 2.15, 8.5, 4.2),
                new MaterialModel("Uranium", 7.45, 3.55, 11, 3.9),
                new MaterialModel("Gallium", 12.2, 5.8, 18, 6.4)
            };
        }
    }

    public class MaterialModel
    {
        public string MaterialName { get; set; }
        public double Coefficient { get; set; }
        public double ErrorValue { get; set; }
        public double HighErrorValue { get; set; }
        public double LowErrorValue { get; set; }

        public MaterialModel(string materialName, double coefficient, double errorValue, double highErrorValue, double lowErrorValue)
        {
            MaterialName = materialName;
            Coefficient = coefficient;
            ErrorValue = errorValue;
            HighErrorValue = highErrorValue;
            LowErrorValue = lowErrorValue;
        }
    }
}

