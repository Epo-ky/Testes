namespace CardGame;

public class GameRound
{
    private readonly CombatResolver _combatResolver = new();

    public CombatResult Play(Card playerCard, Card opponentCard, StatType chosenStat)
    {
        return _combatResolver.Resolve(playerCard, opponentCard, chosenStat);
    }
}
