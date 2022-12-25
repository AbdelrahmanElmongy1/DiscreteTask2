using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {


//
            Console.WriteLine("n1");
            int S = int.Parse(Console.ReadLine());   
            Console.WriteLine("n2");
            int E = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int x=S;x<=E;x++)
            {
                sum = 0;
                for (int i = 1; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        sum += i;              
                }
                if (sum == x)
                    Console.WriteLine( x + "  Is A Perfect Number");
            }








        }
    }
}
