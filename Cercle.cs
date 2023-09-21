using System;

namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe Cercle qui implémente l'interface IForme et qui permet de dessiner un cercle.
    /// </summary>
    public class Cercle : IForme
    {
        /// <summary>
        /// Méthode qui permet de dessiner un cercle.
        /// </summary>
        public void Dessiner()
        {
            Console.WriteLine("   ---   ");
            Console.WriteLine(" ------- ");
            Console.WriteLine("---------");
            Console.WriteLine(" ------- ");
            Console.WriteLine("   ---   ");
        }
    }
}
