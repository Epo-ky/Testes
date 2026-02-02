# Card Game (C# + Angular)

Este repositório contém um esqueleto para um card game com mecânica de comparação de status.
A lógica principal está em C# e a representação visual em Angular.

## Estrutura

- `backend/CardGame`: modelos e resolução de combate em C#.
- `frontend/src/app`: componente Angular que renderiza cartas e compara atributos.

## Fluxo básico

1. A carta do jogador e do oponente possuem três atributos: Força, Destreza e Magia.
2. O jogador escolhe um atributo para comparar.
3. O resultado retorna vitória, derrota ou empate.

## Próximos passos sugeridos

- Integrar o backend C# a uma API (Minimal API/ASP.NET) para alimentar o front-end.
- Implementar deck, compra de cartas e turnos.
- Adicionar nomenclaturas, efeitos e habilidades especiais.
