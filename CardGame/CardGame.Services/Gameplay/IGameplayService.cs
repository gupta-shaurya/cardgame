namespace CardGame.Services.Gameplay
{
    public interface IGameplayService
    {
        int[] InitializeDeck();

        string PlayCard(ref int[] deck);

        void ShuffleDeck(ref int[] deck);
    }
}