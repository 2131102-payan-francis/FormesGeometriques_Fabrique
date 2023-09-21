namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe CreateurCarre qui hérite de la classe CreateurForme et qui permet de créer un carré.
    /// </summary>
    public class CreateurCarre : CreateurForme
    {
        /// <summary>
        /// Méthode qui permet de créer un carré.
        /// </summary>
        /// <returns> Un carré </returns>
        public override IForme CreerForme()
        {
            return new Carre();
        }
    }
}
