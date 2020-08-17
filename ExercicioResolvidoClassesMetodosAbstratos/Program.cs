using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioResolvidoClassesMetodosAbstratos.Entidades;
using ExercicioResolvidoClassesMetodosAbstratos.Entidades.Enums;


namespace ExercicioResolvidoClassesMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Informe a quantidade de figuras: ");
            int quantFiguras = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantFiguras; i++)
            {
                Console.WriteLine($"Dados da figura #{i}: ");
                Console.Write("Retangulo ou Circulo (r, c)? ");
                char letra = char.Parse(Console.ReadLine());
                Console.Write("Cor (Black/Blue/Read): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                if (letra == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio, cor));
                }
            }
            Console.WriteLine();
            Console.WriteLine("AREAS DA FIGURA: ");
            foreach (Figura figura in lista)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
                                                                                                              