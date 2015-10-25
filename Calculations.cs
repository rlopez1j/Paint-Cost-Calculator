using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalc
{
    class Calculations:ReadInput
    {
        private const decimal taxRate = 0.0825M;
        private const decimal laborRate = 0.60M;
        protected static DateTime date = DateTime.Today;

        protected static double sqFt;
        protected static double numGallons;
        protected static decimal laborCost;
        protected static decimal paintCost;
        protected static decimal subTotal;
        protected static decimal tax;
        protected static decimal grandTotal;

        private static void calc_sqFt() { sqFt += (wallHeight * wallLength); }
        private static void calc_numGallons(){ numGallons = sqFt / 400; }
        private static void calc_paintCost() {  paintCost = paintPrice * Convert.ToDecimal(numGallons); }
        private static void calc_laborCost() { laborCost = laborRate * Convert.ToDecimal(sqFt); }
        private static void calc_subTotal() { subTotal = laborCost + paintCost; }
        private static void calc_tax() { tax = subTotal * taxRate; }
        private static void calc_grandTotal() { grandTotal = subTotal + tax; }
        public static void calc_all()
        {
            calc_sqFt();
            calc_numGallons();
            calc_paintCost();
            calc_laborCost();
            calc_subTotal();
            calc_tax();
            calc_grandTotal();
        }
    }
}
