using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Flyweight
{
    public class OptionFactory
    {
        protected Dictionary<string, VehicleOption> options = new Dictionary<string, VehicleOption>();

        public VehicleOption getOption(string name)
        {
            VehicleOption result;
            if (this.options.ContainsKey(name))
            {
                result = this.options[name];
            } 
            else 
            {
                result = new VehicleOption(name);
                this.options.Add(name, result);
            }

            return result;
        }
    }
}
