using System;

namespace CSAssignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalClass NewClass = new NormalClass();

            NewClass.GenericMethod<string>(11, "Eleven");
        }
    }
}

public class NormalClass
{
    public void GenericMethod<T>(int parameter1, T parameter2)
    {
        Console.WriteLine("The parameters:");
        Console.WriteLine(parameter1);
        Console.WriteLine(parameter2);
    }
}
