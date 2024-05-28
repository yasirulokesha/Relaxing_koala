using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;

// SalesPerson class extending Person
public class SalesPerson : Person
{
    public int ID
    {
        get; set;
    }

    // Responsibilities
    public void TakeReservation(Reservation reservation)
    {
        /* Implementation */
    }
    public void SendOrderToKitchen(Order order)
    {
        /* Implementation */
    }
    public void ProcessFinancialTransactions(Payment payment)
    {
        /* Implementation */
    }
    public void TakeOrder(Order order)
    {
        /* Implementation */
    }
    public void PlaceOrders(Order order)
    {
        /* Implementation */
    }
    public void ModifyOrder(Order order)
    {
        /* Implementation */
    }
}