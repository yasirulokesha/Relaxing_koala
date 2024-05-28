using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Payment class
public class Payment
{
    public decimal DueAmount
    {
        get; set;
    }
    public int OrderID
    {
        get; set;
    }
    public Customer Customer
    {
        get; set;
    }
    public string PaymentMethod
    {
        get; set;
    }
    public DateTime DateOfPayment
    {
        get; private set;
    }
}

// CashPayment class extending Payment
public class CashPayment : Payment
{
    // Additional properties or methods specific to cash payment can be added here
}

// CardPayment class extending Payment
public class CardPayment : Payment
{
    // Additional properties or methods specific to card payment can be added here
}