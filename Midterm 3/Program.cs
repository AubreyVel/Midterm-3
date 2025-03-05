using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
     
            int n = 0;
            bool quit = false;
      

           
            
            while (quit == false)
            {
                
                Console.WriteLine("Insert a number, or 999 to quit");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 999) 
                {
                    quit = true;
                }
                else
                {
                    int[] myNumbers = new int[n] ;


                    for (int i = 0; i<n;i++)
                    {
                        Console.WriteLine("input element "+i);
                        myNumbers[i]=Convert.ToInt32(Console.ReadLine());
                    }

                    foreach (int i in myNumbers)
                    {
                        Console.WriteLine(i);
                    }



                }
            }

           



           

        }


        //static void InsertNumber(int n, int[] numbers)
        //  {
        //    bool quit = false;
        //
        //    while (quit == false)
        //    {
        //        Console.WriteLine("Insert a number");
        //    }


        //  }









    }
}
