using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_For_Using_GitIGnore
{
    //Wrap Up about Delegate Lesson : 

    // Declare A Delegate : 
    // delegate <Return_Type> <Delegate_Name> (Pramaters);
    public delegate void del_Printer(string name);

    public delegate int del_ArthOperations(int a,int b);

    public delegate T Del_Plus<T>(T a,T b);

    
    internal class Program
    {
        static void Main(string[] args)
        {
            // delegates instanstion : 
            del_Printer Printer1 = new del_Printer(Print);// Takes Method Name as Parameter.
            del_Printer Printer2 = Print; // also this method

            // delegate invoking :
            Printer1.Invoke("Hello Printer1");//Take the same paramter of original function for invoking ;
            Printer2("Hello Printer2");//also this method for invoking.

            // #########################################################

            // Lambda Expression & Anonymus Functions : 

            // Lambda Expression : 
            del_ArthOperations Operation1 = (a,b)=> a + b;
            Console.WriteLine(Operation1(10,5));
            // Anunymous Function : 
            del_ArthOperations operation2 = delegate (int a, int b) { return a - b; };
            Console.WriteLine(operation2(10, 5));

            // Delegate Chains & Generic delegate : 
            //delegate chains (Subscribe): 
            del_Printer Printer3 = Method1;
            Printer3 += Method2;
            Printer3 += Method3;

            //UnSubscribe : 

            Printer3 -= Method2;

            //Printer3.GetInvocationList();

            Printer3("HI");


            // Generic delegate : 

            Del_Plus<int> Adding =(a,b)=> a + b;
            Del_Plus<string>Concat = (a,b)=> a + " " +b;
            Del_Plus<double>AddDouble = (a,b)=> a + b;

            Console.WriteLine(Adding(99,1));
            Console.WriteLine(Concat("FirstName","LastName"));
            Console.WriteLine(AddDouble(10.9,51.1));


        }
        public static void Print(string name) { Console.WriteLine(name); }

        public static void Method1(string Msg)
        {
            Console.WriteLine($"Method1 : {Msg}");
        }

        public static void Method2(string Msg)
        {
            Console.WriteLine($"Method2 : {Msg}");
        }
        public static void Method3(string Msg)
        {
            Console.WriteLine($"Method3 : {Msg}");
        }
    }
}
