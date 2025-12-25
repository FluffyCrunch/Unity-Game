using UnityEngine;
using System.Collections.Generic;

namespace Chess.Scripts.Core {
    public class PieceSelector : MonoBehaviour {
        private ChessPiece selectedPiece;
        private ChessBoardManager boardManager;

        void Start() {
            boardManager = FindObjectOfType<ChessBoardManager>();
        }

        void Update() {
            if (Input.GetMouseButtonDown(0)) {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

                if (hit.collider != null) {
                    ChessPiece piece = hit.collider.GetComponent<ChessPiece>();
                    if (piece != null) {
                        SelectPiece(piece);
                    } else {
                        DeselectPiece();
                    }
                } else {
                    DeselectPiece();
                }
            }
        }   

        void SelectPiece(ChessPiece piece) {
            selectedPiece = piece;
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            var moves = piece.GetLegalMoves(boardManager.board);
            foreach (var move in moves) {
                var targetPiece = boardManager.board[move.x, move.y];
                if (targetPiece != null && targetPiece.isWhite != piece.isWhite) {
                    ChessBoardPlacementHandler.Instance.Highlight(move.x, move.y, Color.red);
                } else {
                    ChessBoardPlacementHandler.Instance.Highlight(move.x, move.y, Color.green);
                }
            }
        }

        void DeselectPiece() {
            selectedPiece = null;
            ChessBoardPlacementHandler.Instance.ClearHighlights();
        }
    }
} 