using System;

namespace jeu_d_echec
{
    class Program
    {
        static void Main(string[] args)
        {
            //initioalisaton
            Plateau p = new Plateau();
            for (int i = 0; i < 8; i++)
            {
                p.AjoutPiece(new Pion(1, i, 1, true));
            }
            for (int i = 0; i < 8; i++)
            {
                p.AjoutPiece(new Pion(1, i, 6, false));
            }
            //fin initialisation

            while (true)
            {
                Console.WriteLine("quel est la case de la piece que vous voulez changer ? (X9)"); // quelle piece
                string rep = Console.ReadLine();
                int xPiece = char.ToUpper(rep[0]) - 64;
                int yPiece = int.Parse(rep.Substring(1, 1));
                Console.WriteLine("quel est la case ou vpous voulez aller ? (X9)"); //ou se deplacer
                string rep2 = Console.ReadLine();
                int xDep = char.ToUpper(rep[0]) - 64;
                int yDep = int.Parse(rep.Substring(1, 1));
                //recherche quelle piece et quel type
                if (p.Retrouver(xPiece, yPiece) is Pion)
                    ((Pion)p.Retrouver(xPiece, yPiece)).PeutSeDeplacer(xDep, yDep, p);
            }
        }
    }
}

