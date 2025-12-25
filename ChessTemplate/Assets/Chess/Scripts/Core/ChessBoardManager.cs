using UnityEngine;

namespace Chess.Scripts.Core {
    public class ChessBoardManager : MonoBehaviour {
        public ChessPiece[,] board = new ChessPiece[8, 8];

        void Start() {
            foreach (var piece in FindObjectsOfType<ChessPiece>()) {
                var placement = piece.GetComponent<ChessPlayerPlacementHandler>();
                if (placement != null)
                    board[placement.row, placement.column] = piece;
            }
        }
    }
}