using System;

namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть ваше iм'я\n>>>");
            String name = Console.ReadLine();
            Console.WriteLine("Привіт " + name + ", поточна дата та час: " + DateTime.Now.ToString());
        }
    }
}
