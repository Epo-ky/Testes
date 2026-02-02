export type StatType = 'forca' | 'destreza' | 'magia';

export interface Card {
  name: string;
  forca: number;
  destreza: number;
  magia: number;
}

export const STAT_LABELS: Record<StatType, string> = {
  forca: 'Força',
  destreza: 'Destreza',
  magia: 'Magia',
};
