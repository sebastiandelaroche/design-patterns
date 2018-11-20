using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Facade
{
    public class Main
    {
        public void execute()
        {
            AutoWebService webservice = new ImplementationAutoWebService();

            Console.WriteLine(webservice.document(0));
            Console.WriteLine(webservice.document(1));

            List<string> results = webservice.findVehicle(1000, 6000);

            if (results.Count > 0) 
            {
                Console.WriteLine(
                    "Vehículo(s) cuyo precio está comprendido " +
                    "entre 5000 y 7000"
                );

                results.ForEach((string result) => {
                    Console.WriteLine("   " + result);
                });
            }

        }
    }
}
