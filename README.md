# Cardgame

Cardgame is a console application to play cards

## Build

Build the Console Application (Cardgame.ConsoleApp)

```bash
dotnet build Cardgame.ConsoleApp
```

## Important Notes

Some key highlights:
- For shuffling the deck, the Fisher Yates shuffle algorithm has been implemented 
[Fisher Yates Shuffle](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle)

## Usage

Sample Output
```bash
==========================================================================
||                     Welcome to the Card Game!                        ||
||                                                                      ||
|| GAME COMMANDS:                                                       ||
|| + Play : The card at the at the top of the deck would be displayed   ||
|| + Shuffle : Shuffles the cards in hand                               ||
|| + Restart : Restarts the game with all 52 cards in hand              ||
|| + Quit/Exit : Restarts the game with all 52 cards in hand            ||
||                                                                      ||
||                              Have fun!                               ||
==========================================================================

Please enter a command (Play/Shuffle/Restart/Quit): play
The card played is: Six of Diamonds

Please enter a command (Play/Shuffle/Restart/Quit): play
The card played is: Three of Hearts

Please enter a command (Play/Shuffle/Restart/Quit): shuffle
The deck has been shuffled

Please enter a command (Play/Shuffle/Restart/Quit): play
The card played is: Five of Diamonds

Please enter a command (Play/Shuffle/Restart/Quit): restart
The deck has been reset

Please enter a command (Play/Shuffle/Restart/Quit): play
The card played is: Eight of Clubs

Please enter a command (Play/Shuffle/Restart/Quit): restart
The deck has been reset

Please enter a command (Play/Shuffle/Restart/Quit): quit
```

## Acknowledgments

This tool was made possible utilizing the standard libraries (.NET Core and .NET Standard)

## License
[MIT](https://choosealicense.com/licenses/mit/)
