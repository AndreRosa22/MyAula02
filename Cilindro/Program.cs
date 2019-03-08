using System;
using System.Text;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Insira uma altura");
            string a = Console.ReadLine();//altura
            int A = Convert.ToInt32(a);
            Console.WriteLine("Insira um raio");
            string r = Console.ReadLine();//raio
            int R = Convert.ToInt32(r);
            double volume = Math.PI * R * R *A ;//calcula o volume
            double area = 2*Math.PI*R*(R + A);//calcula a area
            string resultadoVolume = $"Volume do cilindro = \u03C0 * raio^2 * altura = {volume:f1}";
            string resultadoArea = $"Area da superficie do cilindro = 2\u03C0 * raio + (raio + altura) = {area:f2}";
            Console.WriteLine(resultadoVolume);
            Console.WriteLine(resultadoArea);
            Console.WriteLine();
            Console.WriteLine("Prime ENTER para sair");
            Console.ReadKey();
        }
    }
}
