using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core {
    public abstract class ChessPiece : MonoBehaviour {
        public int row, column;
        public bool isWhite;

        
        public abstract List<Vector2Int> GetLegalMoves(ChessPiece[,] board);
    }
} 