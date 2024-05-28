using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// Invoice class
public class Invoice
{
    public int InvoiceID
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
    public List<MenuItem> MenuItems
    {
        get; set;
    }
    public decimal ItemPrice
    {
        get; set;
    }
    public DateTime DateOfPurchase
    {
        get; set;
    }
    public decimal TotalPrice
    {
        get; set;
    }

    // Responsibilities
    //public void PrintInvoice(DocumentPrinter printer)
    //{ /* Implementation */
    //}
    //public void SendInvoice(DocumentPrinter printer)
    //{ /* Implementation */
    //}
}