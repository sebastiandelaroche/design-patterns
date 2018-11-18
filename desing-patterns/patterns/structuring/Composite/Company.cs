using System;
namespace desingpatterns.patterns.structuring.Composite
{
    public abstract class Company
    {
        protected static double unitCostVehicle = 5.0;
        protected int nVehicles;

        public void addVehicle()
        {
            nVehicles = nVehicles + 1;
        }

        public abstract double calculateCostMaintenance();

        public abstract bool agregaFilial(Company filial);
    }
}
