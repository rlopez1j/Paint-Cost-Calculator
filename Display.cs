using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalc
{
    class Display:Calculations
    {
        public static string displayInfo()
        {
            return "Day of this quote: " + date.ToString("D") + Environment.NewLine
                    + "Customer Name:  " + customerName + Environment.NewLine
                    + "Customer Phone Number: " + phoneNum + Environment.NewLine
                    + Environment.NewLine
                    + "Total Walls: " + numWalls + Environment.NewLine
                    + "Total SqFt: " + sqFt.ToString("N") + Environment.NewLine
                    + "Number of Gallons of Paint Needed: " + numGallons.ToString("N") + Environment.NewLine
                    + "Price of Paint Per Gallon: $" + paintPrice.ToString("N") + Environment.NewLine
                    + "Cost of Paint: $" + paintPrice.ToString("N") + Environment.NewLine
                    + "Cost of Labor: $" + laborCost.ToString("N") + Environment.NewLine
                    + "Sub Total: $" + subTotal.ToString("N") + Environment.NewLine
                    + "Tax: $" + tax.ToString("N") + Environment.NewLine
                    + Environment.NewLine
                    + "Grand Total: $" + grandTotal.ToString("N") + Environment.NewLine;
        }
        }

   
}
