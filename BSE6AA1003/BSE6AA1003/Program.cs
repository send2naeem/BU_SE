using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSE6AA1003
{
    class student
    {
        public class bse6
        {

        }

        int? a;
        int x;
        object test;

        public student()
        {
            a = null;
        }

        public object GetA()
        {
            //a = 50;
            return a ?? new object();
        }

        public object GetObject()
        {
            object complete = new object();
            return test ?? complete;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(char));

            student obj = new student();
            Console.WriteLine(obj.GetA());

            if(obj.GetA() == null)
            {
                Console.WriteLine("NULL OBJECT RETURNED");
            }
            else
            {
                Console.WriteLine("NOT NULL OBJECT RETURNED");
            }

        }
    }
}
