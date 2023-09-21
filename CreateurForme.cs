namespace SystemeFormeGeometrique
{
    /// <summary>
    /// Classe abstraite CreateurForme qui permet de créer une forme géométrique.
    /// et implémente l'interface IForme.
    /// </summary>
    public abstract class CreateurForme
    {
        /// <summary>
        /// Méthode abstraite qui permet de créer une forme géométrique.
        /// </summary>
        public abstract IForme CreerForme();
    }
}
