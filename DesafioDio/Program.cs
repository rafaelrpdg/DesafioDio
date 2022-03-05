using System;
using DesafioDio.src.Entites;
class Program
{
    public static void Main()
    {
        Fighter player1 = new Fighter("Jorginho", 10, "Lutador", 15);

        Fighter player2 = new Fighter("Fernando", 30, "Lutador", 20);

        Console.WriteLine(player1.Blow(player2));

        Console.WriteLine(player1);
        Console.WriteLine(player2);


    }
}
