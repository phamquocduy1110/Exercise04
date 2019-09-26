using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Import A Value:  ");
            int input = Convert.ToInt32(Console.ReadLine());
            Odd_or_Even_Number(input);
        }
        static void Odd_or_Even_Number(int n)
        {
            if(Even_Number(n))
                Console.WriteLine("{0} is even number", n);
            if(Odd_Number(n))
                Console.WriteLine("{0} is even number", n);
        }
       
        static bool Even_Number(int n)
        {
            return n % 2 == 0;
        }

        public static bool Odd_Number(int n)
        {
            return n % 2 == 1;
        }
    }
}
