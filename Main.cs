using System;

namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe Main qui permet de dessiner une forme géométrique (Carre, Triangle, Cercle).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            // Fonctionnement du programme qui demande à l'utilisateur de choisir une forme à dessiner et qui la dessine à l'écran.
            while (continuer) 
            {
                Console.WriteLine("Quelle forme voulez-vous dessiner?");
                Console.WriteLine("1: Cercle");
                Console.WriteLine("2: Carré");
                Console.WriteLine("3: Triangle");
                
                string choix = Console.ReadLine();
                IForme forme; // Déclaration de la variable forme qui à partir de l'interface IForme peut contenir un objet de type Cercle, Carre ou Triangle 
                CreateurForme createurForme; // Déclaration de la variable createurForme qui contient un objet de type CreateurForme qui permet de créer une forme géométrique.

                switch (choix)
                {
                    case "1":
                        createurForme = new CreateurCercle(); // Création d'un objet de type CreateurCercle qui permet de créer un cercle.
                        forme = createurForme.CreerForme(); // Création d'un objet de type Cercle.
                        break;
                    case "2":
                        createurForme = new CreateurCarre(); // Création d'un objet de type CreateurCarre qui permet de créer un carré.
                        forme = createurForme.CreerForme(); // Création d'un objet de type Carre.
                        break;
                    case "3":
                        createurForme = new CreateurTriangle(); // Création d'un objet de type CreateurTriangle qui permet de créer un triangle.
                        forme = createurForme.CreerForme(); // Création d'un objet de type Triangle.
                        break;
                    default:
                        Console.WriteLine("Choix invalide.");
                        continue; // Retourne au début de la boucle while
                }

                forme.Dessiner(); // Dessine la forme géométrique choisie par l'utilisateur et l'affiche à l'écran.

                Console.WriteLine("Voulez-vous dessiner une autre forme? (O/N)");
                string reponse = Console.ReadLine().ToUpper();

                if (reponse == "N")
                {
                    continuer = false;
                }
            }
        }
    }
}
