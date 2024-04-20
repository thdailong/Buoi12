namespace KeoBuaBao;
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        Console.Write("Player 1 choice: ");
        int player1Choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Player 2 choice: ");
        int player2Choice = Convert.ToInt32(Console.ReadLine());
        string result = game.KeoBuaBao(player1Choice, player2Choice);
        Console.Write("Result: " + result);
    }
}
