using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Escolha o idioma de preferência (Português, Inglês, Espanhol): ");
            string idioma = Console.ReadLine();

            Action<string> mensagem = null;

            if (idioma == "Português")
            {
                mensagem = (nome) => Console.WriteLine("Olá, " + nome + ", Seja bem-vindo!");
            }
            else if (idioma == "Inglês")
            {
                mensagem = (nome) => Console.WriteLine("Hello, " + nome + ", Welcome!");
            }
            else if (idioma == "Espanhol")
            {
                mensagem = (nome) => Console.WriteLine("¡Hola, " + nome + " , Bienvenido!");
            }
            else
            {
                Console.WriteLine("O idioma não foi reconhecido pelo sistema. Escolha novamente com as opções apresentadas.");
                return;
            }

            Console.Write("Digite o seu nome: ");
            string nomeUsuario = Console.ReadLine();

            mensagem(nomeUsuario);
        }
    }
}
