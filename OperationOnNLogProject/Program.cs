using System;
using OperationOnNLogProject;
class Program
{
    public static void Main(String[] args)
    {
        AdditionOfNumbers add = new AdditionOfNumbers();
        Console.WriteLine("Enter two Number");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = add.Add(x, y);
        Console.WriteLine("Result is :-->" + z);
    }
}
