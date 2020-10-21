using System;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace MohTest1Project
{
    class Test1
    {
        static void Main(string[] args)
        {
           // //option one attempt
           // NumberStyles style;
           // string input = "";
           // Console.WriteLine("please enter your input for computation");
           // input = Console.ReadLine();
           // style = NumberStyles.AllowLeadingSign;
           //bool ch = int.TryParse(input,style,out int result);
           // if (ch.Equals(true))
           //     Console.WriteLine("The result is :" + result);
           // else
           //    Console.WriteLine("Failed to convert to integer try another method to convert");

            string input = "";
            int result = 0 ;
            Console.WriteLine("please enter your input for computation");
            input = Console.ReadLine();
            string [] mynumber= input.Split("+");
          
            for(int i=0; i<mynumber.Length;i++)
            {
                
                int temp = int.Parse(mynumber[i]);
                result = result + temp;
            }
            Console.WriteLine(result);
        }
    }
}