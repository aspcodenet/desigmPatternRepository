using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindWeb.Models
{
    public class FakeSupplierRepository : ISupplierRepository
    {
        private List<Supplier> suppliers;

        public FakeSupplierRepository()
        {
            suppliers = new List<Supplier>();
            suppliers.Add(new Supplier { SupplierID=1,ContactName="Stefan", Country="SE" });
            suppliers.Add(new Supplier { SupplierID = 2, ContactName = "Kerstin", Country = "SE" });
            suppliers.Add(new Supplier { SupplierID = 3, ContactName = "Pekka", Country = "FI" });
        }

        public Supplier Get(int supplierID)
        {
            return suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
        }

        public List<Supplier> GetAll()
        {
            return suppliers;
        }
    }
}