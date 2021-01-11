using CardGame.Models.Gameplay;
using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CardGame.Services.Gameplay
{
    public class GameplayService : IGameplayService
    {
        #region Private Fields

        private static readonly Random _random = new Random();

        #endregion Private Fields

        #region Public Methods

        public int[] InitializeDeck()
        {
            int[] deck = new int[Constants.DeckSize-1];

            try
            {
                deck = Enumerable.Range(1, Constants.DeckSize).ToArray();

                ShuffleDeck(ref deck);
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
            }

            return deck;
        }

        public string PlayCard(ref int[] deck)
        {
            string playedCard = string.Empty;

            try
            {
                int topCard = deck[0];

                playedCard = GetCardName(topCard);

                deck = deck.Skip(1).ToArray();
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
            }

            return playedCard;
        }

        public void ShuffleDeck(ref int[] deck)
        {
            try
            {
                int currentDeckLength = deck.Length;

                //Fisher Yates Shuffle Algorithm
                for (int i = 0; i < (currentDeckLength - 1); i++)
                {
                    int randomIndex = i + _random.Next(currentDeckLength - i);

                    int temp = deck[randomIndex];

                    deck[randomIndex] = deck[i];

                    deck[i] = temp;
                }
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
            }
        }

        #endregion Public Methods

        #region Private Methods

        private string GetCardName(int topCard)
        {
            int cardType = (topCard - 1) % Constants.CardTypeCount;

            int suitType = (topCard - 1) / Constants.CardTypeCount;

            StringBuilder cardName = new StringBuilder();

            cardName.Append((Card)cardType);

            cardName.Append(" of ");

            cardName.Append((Suit)suitType);

            return cardName.ToString();
        }

        #endregion Private Methods
    }
}