using CardGame.Models.Common;
using CardGame.Services.Gameplay;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.ExceptionServices;

namespace CardGame.ConsoleApp
{
    public class Program
    {
        #region Private Fields

        private static IServiceProvider _serviceProvider;

        #endregion Private Fields

        #region Public Methods

        public static void Main(string[] args)
        {
            RegisterServices();

            Console.WriteLine(Constants.WelcomeMessage);

            IServiceScope scope = _serviceProvider.CreateScope();

            IGameplayService gameplayService = scope.ServiceProvider.GetRequiredService<IGameplayService>();

            PlayGame(gameplayService);

            DisposeServices();
        }

        #endregion Public Methods

        #region Private Methods

        private static void PlayGame(IGameplayService gameplayService)
        {
            int[] deck = null;

            try
            {
                while (true)
                {
                    if (deck == null)
                    {
                        deck = gameplayService.InitializeDeck();
                    }

                    Console.Write(Constants.CommandMessage);

                    string command = Console.ReadLine().Trim().ToLower();

                    switch (command)
                    {
                        case Constants.PlayCard:
                            string playedCard = gameplayService.PlayCard(ref deck);
                            Console.WriteLine(string.Format(Constants.PlayedCardMessage, playedCard));
                            break;

                        case Constants.ShuffleDeck:
                            gameplayService.ShuffleDeck(ref deck);
                            Console.WriteLine(Constants.ShuffledDeckMessage);
                            break;

                        case Constants.RestartGame:
                            deck = gameplayService.InitializeDeck();
                            Console.WriteLine(Constants.ResetDeckMessage);
                            break;

                        case Constants.QuitGame:
                        case Constants.ExitGame:
                            return;

                        default:
                            Console.WriteLine(Constants.InvalidCommandMessage);
                            break;
                    };
                }
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
            }
        }

        #endregion Private Methods

        #region DI Configuration Methods

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IGameplayService, GameplayService>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        #endregion DI Configuration Methods
    }
}