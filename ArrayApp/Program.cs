// See https://aka.ms/new-console-template for more information
namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int> { 1,2, 3 };   
          
          

            var arr = new Array.Array(1, 2, 3, 4, 5, 6);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
