using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FuncAction
    {
        static void Main(string[] args)
        {
            Func<float> func1 = () => 0.1f;
            Func<int, int, int> func2 = (a, b) => (a + b);

            Action<int, int> act2 = (a, b) =>
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("a = {0}, b = {1}", a, b);
            };


            act2(1, 3);
            Console.WriteLine(func1());
            Console.WriteLine(func2(1,5));
        }
    }
}
