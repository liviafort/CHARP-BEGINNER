using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate{
    public static class overloading{

        //--------------------------------------------------------------//
        //signature is double
        //--------------------------------------------------------------//
        public static double add(double x){
            return x + x;
        }

        //--------------------------------------------------------------//
        //signature is double + int
        //--------------------------------------------------------------//
        public static double add(double x, int y)
        {
            return x + y * 3;
        }

        //--------------------------------------------------------------//
        //signature is int + double
        //--------------------------------------------------------------//
        public static double add(int x, double y)
        {
            return x * x + y;
        }

        //--------------------------------------------------------------//
        //signature is int + double;
        //internal members are accessible only within files in the same 
        //assembly (only in the same class);
        //--------------------------------------------------------------//
        internal static double add(double x, double y)
        {
            return x * x + y * y;
        }


    }
}
