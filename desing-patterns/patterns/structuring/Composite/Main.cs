using System;
namespace desingpatterns.patterns.structuring.Composite
{
    public class Main
    {
        public void execute()
        {
            CompanyWithoutFilial company1 = new CompanyWithoutFilial();
            company1.addVehicle();

            CompanyWithoutFilial company2 = new CompanyWithoutFilial();
            company2.addVehicle();
            company2.addVehicle();

            MotherCompany group = new MotherCompany();
            group.agregaFilial(company1);
            group.agregaFilial(company2);

            group.addVehicle();

            Console.WriteLine("Total maintenance cost: " + 
                              group.calculateCostMaintenance());

        }
    }
}
