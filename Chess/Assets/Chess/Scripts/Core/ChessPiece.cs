using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core {
    public abstract class ChessPiece : MonoBehaviour {
        public int row, column;
        public bool isWhite;

        // Abstract method for getting legal moves
        public abstract List<Vector2Int> GetLegalMoves(ChessPiece[,] board);
    }
} 