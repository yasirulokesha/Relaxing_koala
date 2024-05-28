using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Reservation class
public class Reservation
{
    public int ReservationID
    {
        get; set;
    }
    public Customer Customer
    {
        get; set;
    }
    public DateTime ReservedDateTime
    {
        get; set;
    }
    public int TableID
    {
        get; set;
    }
    public string ReservationStatus
    {
        get; set;
    }
}