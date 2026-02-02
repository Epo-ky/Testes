import { Component } from '@angular/core';
import { Card, STAT_LABELS, StatType } from '../models/card.model';
import { CombatResult, CombatService } from '../services/combat.service';

@Component({
  selector: 'app-card-game',
  templateUrl: './card-game.component.html',
  styleUrls: ['./card-game.component.scss'],
})
export class CardGameComponent {
  readonly statLabels = STAT_LABELS;
  readonly stats: StatType[] = ['forca', 'destreza', 'magia'];

  playerCard: Card = {
    name: 'Guardião da Floresta',
    forca: 7,
    destreza: 5,
    magia: 3,
  };

  opponentCard: Card = {
    name: 'Mago do Abismo',
    forca: 4,
    destreza: 6,
    magia: 9,
  };

  selectedStat: StatType = 'forca';
  result: CombatResult | null = null;

  constructor(private readonly combatService: CombatService) {}

  compare(stat: StatType): void {
    this.selectedStat = stat;
    this.result = this.combatService.resolve(this.playerCard, this.opponentCard, stat);
  }

  reset(): void {
    this.result = null;
    this.selectedStat = 'forca';
  }
}
