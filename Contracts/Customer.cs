using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Customer class extending Person
public class Customer : Person
{
    public int ID
    {
        get; set;
    }

    // Responsibilities
    public void MakeReservation(Reservation reservation)
    { /* Implementation */
    }
    public void ModifyReservation(Reservation reservation)
    { /* Implementation */
    }
    public void CancelReservation(Reservation reservation)
    { /* Implementation */
    }
    public void PlaceOrder(Order order)
    { /* Implementation */
    }
    public void ModifyOrder(Order order)
    { /* Implementation */
    }
    public void SelectDeliveryMethod(Order order, string deliveryMethod)
    { /* Implementation */
    }
    public void AcknowledgeInvoice(Invoice invoice)
    { /* Implementation */
    }
    public void MakePayment(Payment payment)
    { /* Implementation */
    }
}