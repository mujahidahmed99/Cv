namespace Tennis
{
    public class Tennis
    {
        private int Player1, Player2;
        private int forty = 3;
        public string score()
        {
            if(PlayerHasMoreThanForty() && PlayerHasLessThanForty())
            {
                return Outcome();
            }
            else if(BothPlayersHaveFortyOrMore() && BothHaveSamePoints())
            {
                return Outcome();
            }
            else if(BothPlayersHaveFortyOrMore() && PlayerHasOneMore())
            {
                return Player1 > Player2 ? "Player 1 Has Advantage" : "Player 2 Has Advantage";
            }
            else if(BothPlayersHaveFortyOrMore() && PlayerHasTwoMore())
            {
                return Outcome();
            }
            else
            {
                return $"{score(Player1)} - {score(Player2)}";
            }
        }
        public void Player1WinsPoint()
        {
            Player1 ++;
        }
        public void Player2WinsPoint()
        {
            Player2 ++;
        }
        private string Outcome()
        {
            if(Player1 > Player2)
            {
                return "Player 1 Wins!";
            }
            else if(Player2 > Player1)
            {
                return "Player 2 Wins!";
            }
            else
            {
                return "Deuce";
            }
        }
        private bool PlayerHasMoreThanForty()
        {
            return Player1 > forty || Player2 > forty;
        }
        private bool PlayerHasLessThanForty()
        {
            return Player1 < forty || Player2 < forty;
        }
        private bool BothPlayersHaveFortyOrMore()
        {
            return Player1 >= forty && Player2 >= forty;
        }
        private bool BothHaveSamePoints()
        {
            return Player1 == Player2;
        }
        private bool PlayerHasOneMore()
        {
            return Player1 == Player2 + 1 || Player2 == Player1 + 1;
        }
        private bool PlayerHasTwoMore()
        {
            return Player1 == Player2 + 2 || Player2 == Player1 + 2;
        }
        private string score(int score)
        {
            switch(score)
            {
                case 1 :
                return "15";
                case 2 :
                return "30";
                case 3 :
                return "40";
                default :
                return "Love";
            }
        }
    }
}