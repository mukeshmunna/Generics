using TestMaximum;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Finding the maximum of three");
        GenericClass<int> operation = new GenericClass<int>();
        operation.FindMaximum(1, 2, 3);
        GenericClass<float> operation1 = new GenericClass<float>();
        operation1.FindMaximum(1.1f, 2.1f, 3.1f);
        GenericClass<string> operation2 = new GenericClass<string>();
        operation2.FindMaximum("a", "b", "c");

    }
}