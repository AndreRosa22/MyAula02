using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 54;
            int y = 15;
            string a = "Sou uma String Normal";
            string b = @"String Verbatin(literal): ""C:\Users\Andre\Desktop""";
            string c = "Unicode - \u00D8";
            string d = "Outra string normal \t com um tab e uma barra \\";
            string e = @"Outra string verbatin \u001B";
            string f = string.Format("Primeiro numero {0}, segundo numero {1}," +
                " terceiro numero {2}", 3,5,9);
            string g = string.Format("Olá {0} Numero {1}!","mundo", 3);
            string h = $"Sou uma string interpolada- {x} + {y} = ";
            h += $"{x+y}";//texto posto no final da string
            string i = string.Format("{0} mais {1}",54, 15) + $" e' {54+15} ";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(@"Sou um texto verbatin completamente autista @ / : - ");
            Console.WriteLine();
            Console.WriteLine("Prime ENTER para continuar");
            Console.ReadKey();
        }
    }
}
