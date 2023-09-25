using intermediate;
using System.Windows;

namespace lecture_1
{
    public partial class Lecture1
    {
        static void Main(string[] args)
        {
            instance_example classe = new instance_example();
            classe.method_11();
            
        }

        //it can be only accessed by the methods under same parent class
        private static void methode_1(int param1, double param2)
        {
            System.Console.WriteLine("method_1");
        }

        //it can be only accesed from with in the class or any object that inherits off of the class
        protected static void method_2(int param1, double param2)
        {
            System.Console.WriteLine("method_2");
        }

        public void method_3(int param1, double param2)
        {
            System.Console.WriteLine("method_3");
        }

        //it can be used in another class
        public static void method_4(int param1, double param2)
        {
            System.Console.WriteLine("method_4");
        }
    }
}