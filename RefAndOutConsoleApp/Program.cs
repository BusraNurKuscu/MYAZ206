// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

namespace RefAndOutCOnsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var refAndValue = new ReferenceType();
            int a = 23, b = 55;
            Console.WriteLine($"a:{a} b: {b}");
            refAndValue.SwapByRef(ref a, ref b);
            Console.WriteLine($"a:{a} b: {b}");
            var arr = new int[] { 1, 2, 3 };

            arr.SetValue(10, 0);
            Console.WriteLine(arr.GetValue(0));
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



        }
    }
}



























