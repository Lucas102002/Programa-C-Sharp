using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "Uma constante que não muda";

            if(args.Length == 0)
            {
                Console.WriteLine("Por favor informar um número inteiro");
                return;
            }
            
            int inteiro;
            bool test = int.TryParse(args[0], out inteiro);

            if(test == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }
    }
}