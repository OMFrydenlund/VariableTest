namespace VariableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 3.0M;
            decimal sum = a + b; //decimal becomes the priority declaration in this example, higher priority than int due to previously declared decimal

            Console.WriteLine($"A + B = {sum}");
        }
    }
}