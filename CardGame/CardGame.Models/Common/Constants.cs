namespace CardGame.Models.Common
{
    public static class Constants
    {
        public const string PlayCard = "play";
        public const string ShuffleDeck = "shuffle";
        public const string RestartGame = "restart";
        public const string QuitGame = "quit";
        public const string ExitGame = "exit";

        public const string PlayedCardMessage = "The card played is: {0} ";
        public const string ShuffledDeckMessage = "The deck has been shuffled";
        public const string ResetDeckMessage = "The deck has been reset";
        public const string CommandMessage = "\nPlease enter a command (Play/Shuffle/Restart/Quit): ";
        public const string InvalidCommandMessage = "The command is invalid. Please try again!";

        public const string WelcomeMessage = "==========================================================================\n" +
                                             "||                     Welcome to the Card Game!                        ||\n" +
                                             "||                                                                      ||\n" +
                                             "|| GAME COMMANDS:                                                       ||\n" +
                                             "|| + Play : The card at the at the top of the deck would be displayed   ||\n" +
                                             "|| + Shuffle : Shuffles the cards in hand                               ||\n" +
                                             "|| + Restart : Restarts the game with all 52 cards in hand              ||\n" +
                                             "|| + Quit/Exit : Restarts the game with all 52 cards in hand            ||\n" +
                                             "||                                                                      ||\n" +
                                             "||                              Have fun!                               ||\n" +
                                             "==========================================================================";
    }
}