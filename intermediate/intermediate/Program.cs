using intermediate;
using System.Windows;

namespace lecture_1{
    public partial class Lecture1{
        static void Main(string[] args){
            instance_example classe = new instance_example();
            classe.method_11();
            Lecture1 tupla = new Lecture1();
            System.Console.WriteLine(tupla.myTupleReturnedList().Item4);

        }

        //--------------------------------------------------------------//
        //it can be only accessed by the methods under same parent class//
        //--------------------------------------------------------------//
        private static void methode_1(int param1, double param2){
            System.Console.WriteLine("method_1");
        }

        //--------------------------------------------------------------//
        //it can be only accesed from with in the class or any object
        //that inherits off of the class
        //--------------------------------------------------------------//
        protected static void method_2(int param1, double param2){
            System.Console.WriteLine("method_2");
        }

        public void method_3(int param1, double param2){
            System.Console.WriteLine("method_3");
        }

        //--------------------------------------------------------------//
        //it can be used in another class
        //--------------------------------------------------------------//
        public static void method_4(int param1, double param2){
            System.Console.WriteLine("method_4");
        }

        class Car{

        }

        //--------------------------------------------------------------//
        //signature of this method is double, int;
        //a private declaration was needed because the class was
        //private by definition;
        //notice how the code has two different methods with the same
        //name, this was called overloading
        //--------------------------------------------------------------//

        private Car method_4(double param1, double param2) {
            Car myCar = new Car();
            return myCar;
        }


        //--------------------------------------------------------------//
        //it can not be returned in a function multiples types;
        //tuples can be useful;
        //--------------------------------------------------------------//

        public Tuple<int, double, string> myTupleReturned()
        {
            return new Tuple<int, double, string>(32, 120.2, "myTupleReturned!!!");
        }


        public Tuple<int, double, string, List<int>> myTupleReturnedList()
        {
            return new Tuple<int, double, string, List<int>>(32, 120.2, "myTupleReturned!!!", new List<int> { 1, 2, 3});
        }


    }
}