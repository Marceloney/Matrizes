using System;


namespace Exercicio007
{
    class Program
    {
        static void Main(string[] args)
        {   // Inicia uma Variavel "n";
            int n = int.Parse(Console.ReadLine());

            // Cria a matriz linhas e colunas;
            double[,] mat = new double[n, n];

            // Percorre as linhas e colunas "i" and "j";
            for (int i = 0; i < n; i++)
            {   // Lendo a linha inteira recortando os pedacinhos baseados
                // no espaço em branco e guardado todos os pedacinhos no vetor
                // chamado velues
                string[] values = Console.ReadLine().Split(' '); 
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

           
            Console.WriteLine("Main Diagonal");
            // Ler a linha e coluna "i" and "i"
            for (int i = 0;i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
                
            Console.WriteLine();


            int count = 0;
            int positivo = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                    else
                    {
                        positivo++;
                    }
                    
                        
                }
            }

            Console.WriteLine("Negative Numbers = " + count);
            Console.WriteLine("Positive Numbers = " + positivo);



        }

        


    }
}
