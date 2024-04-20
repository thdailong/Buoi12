namespace KeoBuaBao
{
    public class Game
    {
        const int KEO = 1;
        const int BUA = 2;
        const int BAO = 3;
        public string KeoBuaBao(int player1Choice, int player2Choice)
        {
            if (player1Choice < 0 || player1Choice > 3)
            {
                throw new ArgumentException("Invalid player 1 choice");
            }
            if (player2Choice < 0 || player2Choice > 3)
            {
                throw new ArgumentException("Invalid player 2 choice");
            }
            int result = Math.Abs(player1Choice - player2Choice);
            int indexPlayerWin = 0;
            if (result == 0)
            {
                return "Draw";
            }
            else if (result == 1)
            {
                if (player1Choice > player2Choice) indexPlayerWin = 1;
                else indexPlayerWin = 2;
            }
            else
            {
                if (player1Choice > player2Choice) indexPlayerWin = 2;
                else indexPlayerWin = 1;
            }

            return "Player " + indexPlayerWin + " Win";
        }
    }
}