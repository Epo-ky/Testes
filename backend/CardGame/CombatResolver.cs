namespace CardGame;

public class CombatResolver
{
    public CombatResult Resolve(Card playerCard, Card opponentCard, StatType statType)
    {
        var playerScore = playerCard.GetStat(statType);
        var opponentScore = opponentCard.GetStat(statType);

        var outcome = playerScore.CompareTo(opponentScore) switch
        {
            > 0 => RoundOutcome.PlayerWins,
            < 0 => RoundOutcome.OpponentWins,
            _ => RoundOutcome.Draw
        };

        var description = outcome switch
        {
            RoundOutcome.PlayerWins => "Você venceu a rodada!",
            RoundOutcome.OpponentWins => "O oponente venceu a rodada!",
            _ => "Empate!"
        };

        return new CombatResult(playerCard, opponentCard, statType, playerScore, opponentScore, outcome, description);
    }
}
