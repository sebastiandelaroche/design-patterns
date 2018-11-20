using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Facade
{
    public interface Catalog
    {
        List<string> findVehicles(int minPrice, int maxPrice);
    }
}
