using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             int [] numerosfizz = new int [100];
           int suma = 0;
           for (int i = 0; i< numerosfizz.Length; i++)
           {
            numerosfizz [i] = i + 1; 
            {
             suma = suma + numerosfizz [i];
            } 
          
           if ( numerosfizz [i] %3 == 0 && numerosfizz [i] %5 == 0)

           {
              Console.WriteLine ("FizzBuzz");
           }

           else if (numerosfizz [i] %3 == 0)
           {
               Console.WriteLine ("Fizz");
           }
           
           else if (numerosfizz [i] %5 == 0)
           {
               Console.WriteLine ("Buzz");
           }
           
           else 
           {
               Console.WriteLine (numerosfizz[i]);
           }
        }
    }
}
}
