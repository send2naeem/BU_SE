using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    class student
    {
        const int a = 20;
        readonly int aa;

        public student()
        {
            aa = 20;
        }

        public void test()
        {
            a = 30;
        }

    }
    struct student
    {
        public int id;
        string name;
        string address;
    }

    public enum Months
    {
        jan = 1,
        feb = 2,
        mar = 3
    }

    class Program
    {
        static void Main(string[] args)
        {


            int test = 20;
            object obj = test;
            test = (int)obj;

            string str = @"D:\CWM\
            BSE6AA1003";

            int _for;
            _for = 10;

            student obj;
            obj.id = 20;
            int aa = 1;

            if((int)Months.jan == aa)
            {

            }
        }
    }
}
