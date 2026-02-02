namespace CardGame;

public class Deck
{
    private readonly Queue<Card> _cards;

    public Deck(IEnumerable<Card> cards)
    {
        _cards = new Queue<Card>(cards);
    }

    public int Count => _cards.Count;

    public Card Draw()
    {
        if (_cards.Count == 0)
        {
            throw new InvalidOperationException("O deck está vazio.");
        }

        return _cards.Dequeue();
    }

    public static Deck CreateShuffled(IEnumerable<Card> cards, Random? random = null)
    {
        random ??= new Random();
        var shuffled = cards.OrderBy(_ => random.Next()).ToList();
        return new Deck(shuffled);
    }
}
