using intermediate;
using System.Windows;

namespace lecture_1{
    public partial class Lecture1{
        static void Main(string[] args){
            instance_example classe = new instance_example();
            classe.Method_11();
            Lecture1 tupla = new Lecture1();
            System.Console.WriteLine(tupla.MyTupleReturnedList().Item4);

        }

        //--------------------------------------------------------------//
        //it can be only accessed by the methods under same parent class//
        //--------------------------------------------------------------//
        private static void Methode_1(int param1, double param2){
            System.Console.WriteLine("method_1");
        }

        //--------------------------------------------------------------//
        //it can be only accesed from with in the class or any object
        //that inherits off of the class
        //--------------------------------------------------------------//
        protected static void Method_2(int param1, double param2){
            System.Console.WriteLine("method_2");
        }

        public void Method_3(int param1, double param2){
            System.Console.WriteLine("method_3");
        }

        //--------------------------------------------------------------//
        //it can be used in another class
        //--------------------------------------------------------------//
        public static void Method_4(int param1, double param2){
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

        private Car Method_4(double param1, double param2) {
            Car myCar = new Car();
            return myCar;
        }


        //--------------------------------------------------------------//
        //it can not be returned in a function multiples types;
        //tuples can be useful;
        //--------------------------------------------------------------//

        public static Tuple<int, double, string> MyTupleReturned(){
            return new Tuple<int, double, string>(32, 120.2, "myTupleReturned!!!");
        }

        public Tuple<string, int, double, string, double, int, List<string>, Tuple<string, string>> MyTupleAll(){

            return new Tuple<string, int, double, string, double, int, List<string>, Tuple<string, string>>(
                    "livia", 101, 123.45, "fortuanto", 6.65, 1, new List<string> { "list1", "livst2", "list3" }, new Tuple<string, string>("livia1", "fortunato1"));

        }


        public Tuple<int, double, string, List<int>> MyTupleReturnedList(){
            return new Tuple<int, double, string, List<int>>(32, 120.2, "myTupleReturned!!!", new List<int> { 1, 2, 3});
        }


    }
}