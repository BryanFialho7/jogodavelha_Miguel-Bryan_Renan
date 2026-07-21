using System;
class Program
{
    bool Menu = true;

    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Jogo da Velha");
        Console.WriteLine("1 - Iniciar partida");
        Console.WriteLine("2 - Créditos");
        Console.WriteLine("3 - Sair");
        Console.Readline();

        
    }

}
