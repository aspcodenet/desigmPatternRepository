using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWeb.Models
{
    interface ISupplierRepository
    {
        List<Supplier> GetAll();

        Supplier Get(int supplierID);
    }
}
