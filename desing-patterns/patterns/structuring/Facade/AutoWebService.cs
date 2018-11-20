using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Facade
{
    public interface AutoWebService
    {
        string document(int index);
        List<string> findVehicle(int minPrice, int maxPrice);
    }
}
