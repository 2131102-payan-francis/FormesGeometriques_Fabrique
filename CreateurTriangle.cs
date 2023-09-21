namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe CreateurTriangle qui hérite de la classe abstraite CreateurForme et qui permet de créer un triangle.
    /// </summary>
    public class CreateurTriangle : CreateurForme
    {
        /// <summary>
        /// Méthode qui permet de créer un triangle.
        /// </summary>
        /// <returns> Un triangle </returns>
        public override IForme CreerForme()
        {
            return new Triangle();
        }
    }
}
