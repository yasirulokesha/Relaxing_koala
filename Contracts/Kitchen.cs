using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Kitchen class
public class Kitchen
{
    public int OrderID
    {
        get; set;
    }
    public List<MenuItem> OrderItems
    {
        get; private set;
    }
    public string OrderStatus
    {
        get; set;
    }
    public string DeliveryMethod
    {
        get;
    }
}