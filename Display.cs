using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHw1
{
    class Display:Calculations
    {
        public static string show_customerName() { return customerName; }
        public static string show_phoneNumber() {return phoneNum;} 
        public static decimal show_paintPrice() { return paintPrice; }
        public static int show_numWalls(){ return numWalls; }
        public static double show_wallHegiht() { return wallHeight; }
        public static double show_wallLength() { return wallLength; }
        public static string show_date() { return date; }
        public static double show_sqFt() { return sqFt; }
        public static double show_numGallons() { return numGallons; }
        public static decimal show_laborCost() { return laborCost; }
        public static decimal show_subTotal() { return subTotal; }
        public static decimal show_tax() { return tax; }
        public static decimal show_grandTotal() { return grandTotal; }
    }
}
