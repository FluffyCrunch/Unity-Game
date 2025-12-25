using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core {
    public class Pawn : ChessPiece {
        public override List<Vector2Int> GetLegalMoves(ChessPiece[,] board) {
            List<Vector2Int> moves = new List<Vector2Int>();
            int direction = isWhite ? -1 : 1;
            int startRow = isWhite ? 6 : 1;

            ChessPlayerPlacementHandler placement = GetComponent<ChessPlayerPlacementHandler>();
            int currentRow = placement.row;
            int currentCol = placement.column;

            int r = currentRow + direction;
            if (r >= 0 && r < 8) {
                if (board[r, currentCol] == null) {
                    moves.Add(new Vector2Int(r, currentCol));
                    if (currentRow == startRow && board[r + direction, currentCol] == null && r + direction >= 0 && r + direction < 8) {
                        moves.Add(new Vector2Int(r + direction, currentCol));
                    }
                }
                for (int dc = -1; dc <= 1; dc += 2) {
                    int c = currentCol + dc;
                    if (c >= 0 && c < 8 && board[r, c] != null && board[r, c].isWhite != this.isWhite) {
                        moves.Add(new Vector2Int(r, c));
                    }
                }
            }
            return moves;
        }
    }
} 