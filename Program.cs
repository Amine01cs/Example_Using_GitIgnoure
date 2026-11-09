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

        }
        public static void Print(string name) { Console.WriteLine(name); }
    }
}
