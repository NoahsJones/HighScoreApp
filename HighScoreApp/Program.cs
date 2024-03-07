namespace HighScoreApp
{
    internal class Program
    {
        public class PlayerScore
        {
            //auto-implementing two properties with an internal setter so it can only be set inside a method of the class.
            public string Player {  get; internal set; }
            public int Score { get; internal set; }

            //Sets the properties values
            public PlayerScore(string player, int score)
            {
                this.Player = player;
                this.Score = score;
            }
        }

        //Gets the player name and score then makes an object of the PlayerScore class to set the property values then return the object.
        public static PlayerScore WhatIsPlayerAndScore()
        {
            Console.Write("What is your player name: ");
            string player = Console.ReadLine();

            Console.Write("What is your score: ");
            string scoreStr = Console.ReadLine();
            int score = int.Parse(scoreStr);

            PlayerScore playerScore = new PlayerScore(player, score);

            return playerScore;
        }

       
        static void Main(string[] args)
        {
            //Calls the above function/method "WhatIsPlayerAndScore" and then stores the returned object in a new object of the same class type.
            PlayerScore playerScoreCalc = WhatIsPlayerAndScore();

            //Checks to see if the score is a high score, a tie, or a low score and who the winning player is.
            switch (playerScoreCalc.Score)
            {
                case > 25:
                    Console.WriteLine($"New highscore is {playerScoreCalc.Score}");
                    Console.WriteLine($"New highscore holder is {playerScoreCalc.Player}");
                    break;
                case 25:
                    Console.WriteLine($"The old and new highscores are the same at {playerScoreCalc.Score} and the players are {playerScoreCalc.Player} and David.");
                    break;
                case < 25:
                    Console.WriteLine($"The old highschore of 25 could not be broken and is still held by David");
                    break;
            }

        }
    }
}
