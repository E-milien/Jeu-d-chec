using System;
using System.Collections.Generic;

namespace jeu_d_echec
{
    public class Plateau
    {
        private int[,] tab;
        private List<Piece> lesPieces;

        public Plateau()
        {
        }

        public int[,] Tab { get => tab;
            set
            {
                int[,] tmp = new int[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        tmp[i, y] = 0;
                    }
                }
                tab = tmp;
            }
        }

        public List<Piece> LesPieces { get => lesPieces; set => lesPieces = value; }

        public void AjoutPiece(Piece unePiece)
        {
            LesPieces.Add(unePiece);
        }
        public void SeFaitManger(Piece unePiece)
        {
            LesPieces.Remove(unePiece);
        }
        public Piece Retrouver(int numPiece)
        {
            foreach (Piece p in LesPieces)
            {
                if (p.NumPiece == numPiece)
                    return p;
            }
            return new Piece();
        }
        public Piece Retrouver(int x, int y)
        {
            foreach (Piece p in LesPieces)
            {
                if (p.PositionX == x && p.PositionY == y)
                    return p;
            }
            return new Piece();
        }
    }
}

