// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace ConsoleApp;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        HelloFrom("Generated Code");
    }

    static partial void HelloFrom(string name);


}