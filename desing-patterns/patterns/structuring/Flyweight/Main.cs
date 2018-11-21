using System;
namespace desingpatterns.patterns.structuring.Flyweight
{
    public class Main
    {
        public void execute()
        {
            OptionFactory factory = new OptionFactory();
            RequestedVehicle requestedVehicle = new RequestedVehicle();

            requestedVehicle.addOption("air bag", 80, factory);
            requestedVehicle.addOption("electry glasses", 80, factory);

            requestedVehicle.showOptions();

        }
    }
}
