using System;
using System.Globalization;
namespace Exercício_6_M
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz;

            int n = int.Parse(Console.ReadLine());

            matriz = new double[n, n];


            for (int l = 0; l < n; l++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {

                    matriz[l, c] = double.Parse(vetor[c], CultureInfo.InvariantCulture);

                }
            }


            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());
            double soma = 0;

            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matriz[l, c] >= 0)
                    {
                        soma = soma + matriz[l, c];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Soma dos números positivos : " + soma.ToString("F1", CultureInfo.InvariantCulture));


            Console.Write("Linha escolhida : ");
            for (int l = linha; l == linha; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matriz[l, c].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Coluna escolhida : ");
            for (int l = 0; l < n; l++)
            {
                for (int c = coluna; c == coluna; c++)
                {
                    Console.Write(matriz[l, c].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Diagonal principal : ");
            for (int l = 0; l < n; l++)
            {


                Console.Write(matriz[l, l].ToString("F1", CultureInfo.InvariantCulture) + " ");

            }



            Console.WriteLine();
            Console.WriteLine("Matriz alterada: ");
            for (int l = 0; l < n; l++)
            {

                for (int c = 0; c < n; c++)
                {
                    if (matriz[l, c] < 0)
                    {
                        matriz[l, c] = (matriz[l, c]) * (matriz[l, c]);

                    }

                    Console.Write(matriz[l, c].ToString("F1", CultureInfo.InvariantCulture) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
