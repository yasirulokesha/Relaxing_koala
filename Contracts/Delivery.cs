using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Delivery class
public class Delivery
{
    public int OrderID
    {
        get; set;
    }
    public Customer Customer
    {
        get; set;
    }
    public string OrderStatus
    {
        get; set;
    }
    public string DeliveryType
    {
        get; set;
    }
    public string DeliveryPartner
    {
        get; set;
    }

    // Collaborators
    public Kitchen Kitchen
    {
        get; set;
    }
}