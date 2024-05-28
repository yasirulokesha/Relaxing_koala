using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Database class
public class Database
{
    public List<int> CustomerIDs
    {
        get; set;
    }
    public List<string> CustomerNames
    {
        get; set;
    }
    public List<MenuItem> MenuItems
    {
        get; set;
    }
    public List<decimal> TotalAmountsForOrders
    {
        get; set;
    }
    public List<string> DeliveryMethods
    {
        get; set;
    }
    public List<int> InvoiceIDs
    {
        get; set;
    }
}
