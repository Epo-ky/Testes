import { Injectable } from '@angular/core';
import { Card, StatType } from '../models/card.model';

export interface CombatResult {
  playerScore: number;
  opponentScore: number;
  outcome: 'player' | 'opponent' | 'draw';
  description: string;
}

@Injectable({
  providedIn: 'root',
})
export class CombatService {
  resolve(playerCard: Card, opponentCard: Card, stat: StatType): CombatResult {
    const playerScore = playerCard[stat];
    const opponentScore = opponentCard[stat];

    let outcome: CombatResult['outcome'] = 'draw';
    let description = 'Empate!';

    if (playerScore > opponentScore) {
      outcome = 'player';
      description = 'Você venceu a rodada!';
    } else if (playerScore < opponentScore) {
      outcome = 'opponent';
      description = 'O oponente venceu a rodada!';
    }

    return {
      playerScore,
      opponentScore,
      outcome,
      description,
    };
  }
}
