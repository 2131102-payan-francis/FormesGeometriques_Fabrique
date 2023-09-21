namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe CreateurCercle qui hérite de la classe CreateurForme et qui permet de créer un cercle.
    /// </summary>
    public class CreateurCercle : CreateurForme
    {
        /// <summary>
        /// Méthode qui permet de créer un cercle.
        /// </summary>
        ///  <returns> Un cercle </returns>
        public override IForme CreerForme()
        {
            return new Cercle();
        }
    }
}
