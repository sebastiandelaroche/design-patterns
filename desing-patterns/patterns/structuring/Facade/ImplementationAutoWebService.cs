using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.structuring.Facade
{
    public class ImplementationAutoWebService: AutoWebService
    {
        protected Catalog catalog = new CatalogComponent();
        private DocumentManagement documentManagement = new DocumentManagementComponent();


        public string document(int index)
        {
            return this.documentManagement.document(index);
        }

        public List<string> findVehicle(int minPrice, int maxPrice)
        {
            return this.catalog.findVehicles(minPrice, maxPrice);
        }
    }
}
