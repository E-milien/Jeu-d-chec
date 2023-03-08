using System;
namespace jeu_d_echec
{
    public class Pion : Piece
    {
        public Pion(int valeur, int positionX, int positionY, bool blanc)
            : base(valeur, positionX, positionY, blanc)
        {
        }

        public bool PeutSeDeplacer(int x, int y, Plateau p)
        {
            if (base.Blanc)
            {
                if (base.PositionY == 1 && base.PositionX == x && (base.PositionY + 2 == y || base.PositionY + 1 == y))
                {
                    return this.Deplacement(x, y, p);
                }
                else if (base.PositionX == x && base.PositionY + 1 == y)
                {
                    return this.Deplacement(x, y, p);
                }
                return false;
            }
            else
            {
                if (base.PositionY == 6 && base.PositionX == x && (base.PositionY - 2 == y || base.PositionY - 1 == y))
                {
                    return this.Deplacement(x, y, p);
                }
                else if (base.PositionX == x && base.PositionY - 1 == y)
                {
                    return this.Deplacement(x, y, p);
                }
                return false;
            }
        }
    }
}

