using SF_13_2017.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_13_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.SetIme("Marija");
            Console.WriteLine("Pozdrav" + a.GetIme());
            Console.ReadLine();
        }
    }
}
