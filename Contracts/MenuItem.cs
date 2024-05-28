using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaxing_Koala_.Contracts;
// MenuItem class
public class MenuItem
{
    public int MenuItemID
    {
        get; set;
    }
    public decimal Price
    {
        get; set;
    }
    public string Description
    {
        get; set;
    }
}