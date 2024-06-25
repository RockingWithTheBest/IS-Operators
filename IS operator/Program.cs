using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object num = 0;
            num = "string";
            bool check = num is int;
            Console.WriteLine(check);
        }
    }
}
