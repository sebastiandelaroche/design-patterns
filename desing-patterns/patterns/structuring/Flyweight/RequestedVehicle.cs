using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Flyweight
{
    public class RequestedVehicle
    {
        protected List<VehicleOption> options = new List<VehicleOption>();
        protected IList<int> optionsSalePrices = new List<int>();

        public void addOption(string name, int salePrice, OptionFactory factory)
        {
            this.options.Add(factory.getOption(name));
            this.optionsSalePrices.Add(salePrice);
        }

        public void showOptions()
        {
            int index, lenght;
            lenght = this.options.Count;
            for (index = 0; index < lenght; index++)
            {
                options[index].visualize(this.optionsSalePrices[index]); 
                Console.WriteLine();
            }
        }
    }
}
