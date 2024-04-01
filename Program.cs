using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[,] mat = new int[5, 5];
        bool sair = false;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mat[i, j] = rand.Next(100);
            }
        }

        Console.WriteLine();

        do
        {
            Console.WriteLine("Digite: linha e coluna");
            int lin = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (lin == 0 && col == 0)
            {
                Console.WriteLine("Para sair digite 0,0");
                sair = true;
            }
            else
            {
                Console.WriteLine("O valor é: " + mat[lin - 1, col - 1]);
            }

        } while (!sair);
    }
}
