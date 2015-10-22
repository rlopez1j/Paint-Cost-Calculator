using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHw1
{
    class ReadInput
    {
        protected static string customerName;
        protected static string phoneNum;
        protected static decimal paintPrice;
        protected static int numWalls;
        protected static double wallLength;
        protected static double wallHeight;

        public static void getCustomerName(string name){ customerName = name; }
        public static void getPhoneNum(string num) { phoneNum = num; }
        public static void getPaintPrice(string price) { paintPrice = Convert.ToDecimal(price); }
        public static void getNumWalls(string n) { numWalls = Convert.ToInt32(n); }
        public static void getWallLength(string l) { wallLength = Convert.ToDouble(l); }
        public static void getWallHeight(string h) { wallHeight = Convert.ToDouble(h); }
       
    }
}
