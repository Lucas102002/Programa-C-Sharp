using System;

namespace ListaDeConvidados
{
    class Program
    {
        private static string[] ListaDeConvidados = {
            "Maria",
            "José",
            "Paula",
            "Rodrigo",
            "Aline"
        };

        static void Main (string[] args)
        {
            Console.WriteLine("Informe o nome do convidado: ");
            var nome = Console.ReadLine();

            if(nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o programa");
                return;
            }
            Console.WriteLine("Informe a idade do convidado: ");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não informad para seguir com o programa");
            }

            bool estaConvidado;
            switch (nome)
            {
                case "Maria":
                    estaConvidado = true;
                    break;
                case "José":
                    estaConvidado = true;
                    break;
                case "Paula":
                    estaConvidado = true;
                    break;
                case "Rodrigo":
                    estaConvidado = true;
                    break;
                case "Aline":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns, seja bem-vindo à festa");
            }else if(estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados,por favor verificar com a pessoa que te convidou");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa");
            }
        }
    }
}
