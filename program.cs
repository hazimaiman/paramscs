using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //method overloading = methods takes a variable number of arguments 
            //                     parameter type must be a sinlg -dimensional array
           

            double total = CheckOut(3.99, 5.45, 14,45);
            

            Console.WriteLine(total);

            Console.ReadKey();
       
        }
        static double CheckOut( params double[] prices)
            
        {
            double total = 0;
            
            foreach( double price in prices)
            {
                total += price;
            }

            return total;
        }
        
    }
    }





   
