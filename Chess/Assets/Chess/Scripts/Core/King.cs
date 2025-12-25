using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core {
    public class King : ChessPiece {
        public override List<Vector2Int> GetLegalMoves(ChessPiece[,] board) {
            List<Vector2Int> moves = new List<Vector2Int>();
            int[] dRows = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dCols = { -1, 0, 1, -1, 1, -1, 0, 1 };

            ChessPlayerPlacementHandler placement = GetComponent<ChessPlayerPlacementHandler>();
            int currentRow = placement.row;
            int currentCol = placement.column;

            for (int i = 0; i < 8; i++) {
                int r = currentRow + dRows[i];
                int c = currentCol + dCols[i];
                if (r >= 0 && r < 8 && c >= 0 && c < 8) {
                    if (board[r, c] == null || board[r, c].isWhite != this.isWhite) {
                        moves.Add(new Vector2Int(r, c));
                    }
                }
            }
            return moves;
        }
    }
} 