using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHw1
{
    class Display:Calculations
    {
        //May not need: 

        //public static string show_customerName() { return customerName; }
        //public static string show_phoneNumber() {return phoneNum;} 
        //public static decimal show_paintPrice() { return paintPrice; }
        //public static int show_numWalls(){ return numWalls; }
        //public static double show_wallHegiht() { return wallHeight; }
        //public static double show_wallLength() { return wallLength; }
        //public static string show_date() { return date; }
        //public static double show_sqFt() { return sqFt; }
        //public static double show_numGallons() { return numGallons; }
        //public static decimal show_laborCost() { return laborCost; }
        //public static decimal show_subTotal() { return subTotal; }
        //public static decimal show_tax() { return tax; }
        //public static decimal show_grandTotal() { return grandTotal; }

       public static string displayInfo()
        {
            return "Day of this quote: " + date + Environment.NewLine
                    + "Customer Name:  " + customerName + Environment.NewLine
                    + "Customer Phone Number: " + phoneNum + Environment.NewLine
                    + Environment.NewLine
                    + "Total Walls: " + numWalls + Environment.NewLine
                    + "Total SqFt: " + sqFt + Environment.NewLine
                    + "Number of Gallons of Paint Needed: " + numGallons + Environment.NewLine
                    + "Price of Paint Per Gallon: " + paintPrice + Environment.NewLine
                    + "Cost of Paint: " + paintPrice + Environment.NewLine
                    + "Cost of Labor: " + laborCost + Environment.NewLine
                    + "Sub Total: " + subTotal + Environment.NewLine
                    + "Tax: " + tax + Environment.NewLine
                    + Environment.NewLine
                    + "Grand Total: " + grandTotal + Environment.NewLine;
        }
        }

   
}
