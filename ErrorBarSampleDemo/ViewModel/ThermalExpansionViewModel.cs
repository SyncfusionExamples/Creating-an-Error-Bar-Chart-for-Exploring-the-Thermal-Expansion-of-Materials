using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorBarSampleDemo
{
    public class ThermalExpansionViewModel
    {
        public ObservableCollection<ThermalExpansionModel> ThermalExpansion { get; set; }

        public ThermalExpansionViewModel()
        {
            ThermalExpansion = new ObservableCollection<ThermalExpansionModel>()
            {
                new ThermalExpansionModel("Erbium", 4.4, 12),
                new ThermalExpansionModel("Samarium", 5.3, 11),
                new ThermalExpansionModel("Yttrium", 3.3, 11),
                new ThermalExpansionModel("Carbide", 3.5, 9.4),
                new ThermalExpansionModel("Tin", 9.2, 20),
                new ThermalExpansionModel("Holmium", 3.9, 11),
                new ThermalExpansionModel("Thulium", 4.9, 12),
                new ThermalExpansionModel("Scandium", 4.2, 8.5),
                new ThermalExpansionModel("Uranium", 3.9, 11),
                new ThermalExpansionModel("Gallium", 6.4, 18)
            };
        }
    }

    
}

