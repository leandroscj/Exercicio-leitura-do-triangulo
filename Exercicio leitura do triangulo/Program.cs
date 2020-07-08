using System;

namespace Exercicio_leitura_do_triangulo
{
    static class Program
    {

        static void Main(string[] args)
        {
            Triangulo ret = new Triangulo();

            Console.WriteLine("Digite a largura do Triangulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a altura do Triangulo:");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + ret.Area().ToString("F2"));
            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("f2"));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2"));

        }
    }
}
