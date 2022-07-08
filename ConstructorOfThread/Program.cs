using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConstructorOfThread
{
    internal class Program
    {
        static void Test()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test : "+i);
            }
        }

        //method with parameter 
        static void Test(Object max)
        {
            int ma = Convert.ToInt32(max);
            for (int i = 0; i < ma; i++)
            {

                Console.WriteLine("Test : " + i);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Thread Start ");
            //ThreadStart is delegate and we are instatiation of it 
            //ThreadStart obj = new ThreadStart(Test);
            //or
            //ThreadStart obj = Test;

            //or - lambada expression

            //ThreadStart obj = () => Test();
            //or
            //parameterless thread start

            //ThreadStart obj = () =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Test : " + i);
            //    }
            //};
            //or
            // ThreadStart obj = delegate { Test(); };

            //Thread thread = new Thread(obj);
            //Console.WriteLine("Thread ");
            //Thread t = new Thread(Test);  
            //t.Start();

            //parameterized ThreadStart - only takes object

            ParameterizedThreadStart obj1 = new ParameterizedThreadStart(Test);
            Thread t1 = new Thread(obj1);
            Console.WriteLine("____Parameter ThreadStart");
            //passing value of parameter
            t1.Start(2);

           // Test();

            Console.Read();
        }
    }
}
