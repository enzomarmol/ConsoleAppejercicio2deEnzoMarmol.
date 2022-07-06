using System;

namespace ConsoleAppejercicio2deEnzoMarmol
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3, p, area, perimetro;

            Console.WriteLine("ingrese el valor del lado1");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del lado2");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del lado3");
            lado3 = double.Parse(Console.ReadLine());

            p = (lado1 + lado2 + lado3) / 2;
            Console.WriteLine($"el semiperimetro es {p}");



            area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));
            Console.WriteLine($"el area es {area}");

            perimetro = lado1 + lado2 + lado3;

            Console.WriteLine($"el perimetro es {perimetro}");


            if (Math.Pow(lado1, 2) == Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                Console.Write($"es un triangulo rectangulo");
            }
            else
            {
                if (Math.Pow(lado1, 2) > Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
                {
                    Console.Write($"es un triangulo obtusangulo");
                }
                else
                {
                    if (Math.Pow(lado1, 2) < Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
                    {
                        Console.Write($"es un triangulo acutangulo");
                    }
                    else
                    {
                        Console.Write($"no es un triangulo");
                        Console.ReadLine();
                    }
                }

            }
        }
    }
}