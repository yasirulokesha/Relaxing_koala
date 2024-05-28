using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Order class
public class Order
{
    public Customer Customer
    {
        get; set;
    }
    public int OrderID
    {
        get; set;
    }
    public string OrderStatus
    {
        get; set;
    }
    public List<MenuItem> OrderItems
    {
        get; set;
    }
    public string DeliveryMethod
    {
        get; set;
    }
    public float OrderAmount
    {
        get; set;
    }

    // Responsibilities
    public void InformKitchen(Kitchen kitchen)
    { /* Implementation */
    }
    public void StoreDataIntoDatabase(Database database)
    { /* Implementation */
    }
}