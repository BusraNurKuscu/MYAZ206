// See https://aka.ms/new-console-template for more information
namespace RefAndOutCOnsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var refAndValue = new ReferenceType();
            int a = 23, b = 55;
            Console.WriteLine($"a:{a} b: {b}");
            refAndValue.SwapByRef(ref a, ref b);
            Console.WriteLine($"a:{a} b: {b}");


        }
    }
}



























