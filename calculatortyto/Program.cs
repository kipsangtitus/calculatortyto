using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq.Expressions;

namespace calculatortyto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double n1, n2;
            double result = 0;
            int operation = 0;

            Console.WriteLine("Entre the operation that you would like to perform");
            
            
            
            while (operation != 8)
            {
                operation = Menu();

                if (operation == 8)
                    return;

            

                //get the values
                Console.WriteLine("Input the first number");
                n1 = getnumbers();
               
                
                Console.WriteLine("Input the second number");
                n2 = getnumbers();

                if (operation==1)
                {
                    result = n1 + n2;
                }
                else if (operation==2)
                {
                    result = n1 - n2;
                }
                else if (operation==3)
                {
                    result = n1 * n2;
                }
                else if (operation==4)
                {
                    try
                    {
                           result = n1 / n2;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    result = n1 / n2;
                    
                }
                else if (operation==5)
                {
                    result = n1 % n2;
                }
                else if (operation==6)
                {
                    result = Math.Asin(Convert.ToDouble(Console.ReadLine()));
                }
                else if (operation==7)
                {
                    result = Math.Acos(Convert.ToDouble(Console.ReadLine()));
                }
                else if (operation==8)
                {
                  //end of program
                }
                else
                {
                    //take no action
                }
                Console.WriteLine($"The result of the operation is :{result}");
                
                
                
                
                
               


            }



        }
        /// <summary>
        /// gets the number based on the user input
        /// </summary>
        /// <returns></returns>

        private static double getnumbers()
        {
            try
            {
                //get the number
                double number = Convert.ToDouble(Console.ReadLine());
                return number;
            }
            catch
            {
                //if there is an error in the input
                Console.WriteLine("error in input!");
                return 0;

            }
        }
        private static int Menu()
        {
            Console.WriteLine("entre the number corresponding to the operation");
            /*Console.WriteLine("1.addition"+Environment.NewLine+"2.subtraction"+Environment.NewLine+
                              "3.multiplication"+Environment.NewLine+"4.division"+Environment.NewLine+
                              "5.modulus"+Environment.NewLine+"6.sine"+Environment.NewLine+"7.cosine"+Environment.NewLine+
                              "8.end program");*/
            Console.WriteLine("1)+:2).-:3).*:4)./:5).%:6.sine:7.cosine:8.end");
            //get the option
            int operation;
            try
            {
                operation = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {

                operation = 0;
            }

            return operation;


        }
        
        
    }
}