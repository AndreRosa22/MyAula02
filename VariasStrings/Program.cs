using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Sou uma String Normal";
            string b = @"String Verbatin(literal): ""C:\Users\Andre\Desktop""";
            string c = "Unicode - \u00D8";
            string d = "Outra string normal \t com um tab e uma barra \\";
            string e = @"Outra string verbatin \u001B";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine();
            Console.WriteLine("Prime ENTER para continuar");
            Console.ReadKey();
        }
    }
}
