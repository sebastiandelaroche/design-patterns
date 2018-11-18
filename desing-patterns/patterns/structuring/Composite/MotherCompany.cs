using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Composite
{
    public class MotherCompany: Company
    {
        protected List<Company> filiales = new List<Company>();

        public override bool agregaFilial(Company filial)
        {
            this.filiales.Add(filial);

            return true;
        }

        public override double calculateCostMaintenance()
        {
            double cost = 0.0;

            Console.WriteLine(nVehicles.ToString());

            this.filiales.ForEach((Company filial) => {
                cost = cost + filial.calculateCostMaintenance();
            });

            return cost + nVehicles * unitCostVehicle;
        }

    }
}
