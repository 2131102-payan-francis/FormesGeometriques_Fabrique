using System;

namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe Triangle qui implémente l'interface IForme et qui permet de dessiner un triangle.
    /// </summary>
    public class Triangle : IForme
    {
        /// <summary>
        /// Méthode qui permet de dessiner un triangle.
        /// </summary>
        public void Dessiner()
        {
            Console.WriteLine("    ^    ");
            Console.WriteLine("   ^^^   ");
            Console.WriteLine("  ^^^^^  ");
            Console.WriteLine(" ^^^^^^^ ");
            Console.WriteLine("^^^^^^^^^");
        }
    }
}
