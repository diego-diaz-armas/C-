using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUdemy4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Operadore de igualdad ");
            Console.WriteLine(" ");
            int a = 10, b = 11, c = 10;
            Console.WriteLine("Operador de igualdad y mis datos son = ");
            Console.WriteLine(" a= {0} ,b= {1} ,c= {2}",a,b,c);
            Console.WriteLine(" ");
            Console.WriteLine(" COnparacion de igualacion entre a y c ");
            var data1 = a == c;
            Console.WriteLine("el resultado es  "+data1);
            Console.WriteLine(" ");
            Console.WriteLine("y entre b == c");
            var data2 = b == c;
            Console.WriteLine("el resultado es  "+data2);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.ReadLine();
        }
    }
}
