using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesgulluqBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simvol daxil edin:");
            char k = Convert.ToChar(Console.ReadLine());


            if (k == '-')
            {
                if (a < b)
                {
                    Console.WriteLine("netice: " + (b - a));
                }
            }
             else if (k == '+') 
            {
                Console.WriteLine("netice: " + a + b );
            }
            else if (k == '*')
            {
                Console.WriteLine("netice: " + a * b );
            }
            if (k == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("0-a bolme emeli yoxdur. Yeni qiymeti daxil edin:");
                    b = Cconsole.Readline();
                    Console.WriteLine("netice: " + a / b);
                }
                


            else
                {
                    Console.WriteLine("netice: " + a / b);
                }
            }
            


        }
    }
}
