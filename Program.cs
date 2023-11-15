namespace VariableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 3.0M;
            decimal sum = a + b;

            Console.WriteLine($"A + B = {sum}");
        }
    }
}