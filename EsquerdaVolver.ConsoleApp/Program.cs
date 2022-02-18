using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numEntradas = 0;
                string direcao = "N";
                string movimentos = "";
                Console.WriteLine("Esquerda Volver!");
                Console.Write("0 para sair\nInsira a quantidade de movimentos: ");
                numEntradas = int.Parse(Console.ReadLine());
                if (numEntradas == 0)
                {
                    Console.WriteLine("Fechando o programa...");
                    break;
                }
                for (int i = 0; i < numEntradas; i++)
                {
                    Console.Write($"Insira o movimento {i + 1}: ");
                    movimentos += Console.ReadLine().ToUpper();
                }
                for (int j = 0; j < movimentos.Length; j++)
                {
                    if (movimentos[j] == 'D')
                    {
                        if (direcao == "N")
                        {
                            direcao = "L";
                        }
                        else if (direcao == "L")
                        {
                            direcao = "S";
                        }
                        else if (direcao == "S")
                        {
                            direcao = "O";
                        }
                        else if (direcao == "O")
                        {
                            direcao = "N";
                        }
                    }
                    else if (movimentos[j] == 'E')
                    {
                        if (direcao == "N")
                        {
                            direcao = "O";
                        }
                        else if (direcao == "O")
                        {
                            direcao = "S";
                        }
                        else if (direcao == "S")
                        {
                            direcao = "L";
                        }
                        else if (direcao == "L")
                        {
                            direcao = "N";
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDireção final: {0}\n", direcao);
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
