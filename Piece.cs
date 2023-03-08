using System;
namespace jeu_d_echec
{
    public class Piece
    {
        private int numPiece;
        private int valeur;
        private int positionX;
        private int positionY;
        private bool blanc;

        public Piece()
        {
        }

        public Piece(int valeur, int positionX, int positionY, bool blanc)
        {
            this.NumPiece++;
            this.valeur = valeur;
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.Blanc = blanc;
        }

        public int Valeur
        { get => valeur; set => valeur = value; }
        public int PositionX
        { get => positionX; set => positionX = value; }
        public int PositionY
        { get => positionY; set => positionY = value; }
        public bool Blanc { get => blanc; set => blanc = value; }
        public int NumPiece { get => numPiece;private set => numPiece = value; }

        public bool Deplacement(int x, int y, Plateau lePlateau)
        {
            lePlateau.Tab[this.PositionX, this.positionY] = 0;
            if (lePlateau.Tab[this.PositionX, this.positionY] == 1)
            {
                if (lePlateau.Retrouver(x, y).Blanc != this.Blanc)
                {
                    lePlateau.SeFaitManger(lePlateau.Retrouver(x, y));
                    this.PositionX = x;
                    this.positionY = y;
                    lePlateau.Tab[this.PositionX, this.positionY] = 1;
                }
                else
                    return false;
            }
            return true;
        }
    }
}

