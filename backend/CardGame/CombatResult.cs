namespace CardGame;

public record CombatResult(
    Card PlayerCard,
    Card OpponentCard,
    StatType StatType,
    int PlayerScore,
    int OpponentScore,
    RoundOutcome Outcome,
    string Description);

public enum RoundOutcome
{
    PlayerWins,
    OpponentWins,
    Draw
}
