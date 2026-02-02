namespace CardGame;

public record Card(
    string Name,
    int Forca,
    int Destreza,
    int Magia)
{
    public int GetStat(StatType statType) => statType switch
    {
        StatType.Forca => Forca,
        StatType.Destreza => Destreza,
        StatType.Magia => Magia,
        _ => throw new ArgumentOutOfRangeException(nameof(statType), statType, "Stat inválido.")
    };
}
