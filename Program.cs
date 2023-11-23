using System.Globalization;
namespace EstruturaRepetitivaFor
{
    class program
    {
        static void Main(string[] args)
        {

            // For geralmente e usado quando você sabe a quantidade de repetições diferente da estrutura repetitiva While.

            int N, x, soma;
            N = int.Parse(Console.ReadLine());

            soma = 0;
            // inicio; condição; incremento)
            for (int i = 1; i <= N; i = i + 1) // ou i++ que seria a mesma coisa
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;


            }
            Console.WriteLine(soma);

            Console.ReadLine();




        }
    }
}