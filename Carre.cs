using System;

namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe Carre qui implémente l'interface IForme et qui permet de dessiner un carré.
    /// </summary>
    public class Carre : IForme
    {
        /// <summary>
        /// Méthode qui permet de dessiner un carré.
        /// </summary>
        public void Dessiner()
        {
            int carre = 5;

            for (int i = 0; i < carre; i++)
            {
                for (int j = 0; j < carre; j++)
                {
                    Console.Write("[]");
                }
                Console.WriteLine();
            }
        }
    }
}
