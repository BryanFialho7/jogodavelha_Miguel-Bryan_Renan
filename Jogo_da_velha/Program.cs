using System;
class Program
{
    static void Main()
    {
         Menu();
    }
    static void Menu()
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo " + nome + "!");
            Jogo();
        }
    static void Jogo()
    {

    Console.WriteLine("O jogo começou!");
    Console.WriteLine("  1  |  2  |  3  ");
    Console.WriteLine("----------------");  
    Console.WriteLine("  4  |  5  |  6 ");
    Console.WriteLine("----------------");  
    Console.WriteLine("  7  |  8  |  9  ");

    Console.WriteLine("Escolha uma posição:");
    string posicao = Console.ReadLine();
    if(posicao == " ")
        {
            Console.WriteLine("X");
        }


    }
}