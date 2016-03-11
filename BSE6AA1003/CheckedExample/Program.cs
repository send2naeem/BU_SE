using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedExample
{
    class student
    {
        public static explicit operator int(student obj)
        {
            return 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            student obj = new student();
            int aa = (int) obj;
            Console.WriteLine(aa);

            byte b = 255;

            int a = 20;
            b = (byte) a;

            unchecked
            {
                b++;
            }
            Console.WriteLine(b);
        }
    }
}
