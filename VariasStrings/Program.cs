using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //PARA IMPRIMIR CARATERES
            double xx = 0.12345;//Exercicio 3
            int ii = 18;//Exercicio 3
            int x = 54;
            int y = 15;
            string a = "Sou uma String Normal";//Exercicio 1
            string b = @"String Verbatin(literal): ""C:\Users\Andre\Desktop"" ";//Exercicio 1
            string c = "Unicode - \u00D8";//Exercicio 1
            string d = "Outra string normal \t com um tab e uma barra \\";//Exercicio 1
            string e = @"Outra string verbatin \u001B";//Exercicio 1
            string f = string.Format("Primeiro numero {0}, segundo numero {1}," +
                " terceiro numero {2}", 3,5,9);//Exercicio 2
            string g = string.Format("Olá {0} Numero {1}!","mundo", 3);//Exercicio 2
            string h = $"Sou uma string interpolada- {x} + {y} = ";//Exercicio 2
            h += $"{x+y}";//texto posto no final da string
            string i = string.Format("{0} mais {1}",54, 15) + $" e' {54+15} ";//Exercicio 2

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(@"Sou um texto verbatin completamente autista @ / : - ");//Exercicio2
            Console.WriteLine($"x= {xx:f2}");//Exercicio 3
            Console.WriteLine($"{xx:p1}");//Exercicio 3
            Console.WriteLine($"{ii:x}");//Exercicio 3
            Console.WriteLine($"{ii:c}");//Exercicio 3
            Console.WriteLine();
            Console.WriteLine("Prime ENTER para sair");
            Console.ReadKey();
        }
    }
}
