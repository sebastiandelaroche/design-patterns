using System;
namespace desingpatterns.patterns.structuring.Composite
{
    public class CompanyWithoutFilial: Company
    {

        public override bool agregaFilial(Company filial)
        {
            return false;
        }

        public override double calculateCostMaintenance()
        {
            return nVehicles * unitCostVehicle;
        }
    }
}
