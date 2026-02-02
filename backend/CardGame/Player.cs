using System.Collections.ObjectModel;

namespace CardGame;

public class Player
{
    public Player(string name, IEnumerable<Card> deck)
    {
        Name = name;
        Deck = new ReadOnlyCollection<Card>(deck.ToList());
    }

    public string Name { get; }
    public ReadOnlyCollection<Card> Deck { get; }
}
