using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core {
    public class Queen : ChessPiece {
        public override List<Vector2Int> GetLegalMoves(ChessPiece[,] board) {
            List<Vector2Int> moves = new List<Vector2Int>();
            int[] dRows = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dCols = { -1, 0, 1, -1, 1, -1, 0, 1 };

            ChessPlayerPlacementHandler placement = GetComponent<ChessPlayerPlacementHandler>();
            int currentRow = placement.row;
            int currentCol = placement.column;

            for (int dir = 0; dir < 8; dir++) {
                int r = currentRow + dRows[dir];
                int c = currentCol + dCols[dir];

                while (r >= 0 && r < 8 && c >= 0 && c < 8) {
                    if (board[r, c] == null) {
                        moves.Add(new Vector2Int(r, c));
                    } else {
                        if (board[r, c].isWhite != this.isWhite)
                            moves.Add(new Vector2Int(r, c)); 
                        break;
                    }
                    r += dRows[dir];
                    c += dCols[dir];
                }
            }
            return moves;
        }
    }
} 