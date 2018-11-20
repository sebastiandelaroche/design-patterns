using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Facade
{
    public class CatalogComponent: Catalog
    {
        protected object[] vehicleDescription = 
        {
            "Berlina 5 puertas", 6000, "Compacto 3 puertas", 4000,
            "Espace 5 puertas", 8000, "Break 5 puertas", 7000,
            "Coupé 2 puertas", 9000, "Utilitario 3 puertas", 5000
        };

        public List<string> findVehicles(int minPrice, int maxPrice)
        {
            int index, lenght;
            List<string> result = new List<string>();
            lenght = vehicleDescription.Length / 2;

            for (index = 0; index < lenght; index++)
            {
                int price = (int)vehicleDescription[2 * index + 1];
                if ((price >= minPrice) && (price <= maxPrice))
                    result.Add((string)vehicleDescription[2 * index]);
            }

            return result;
        }
    }
}
