namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Refraction : Abnormality
    {
        // Singleton instance
        private static readonly Refraction _instance = new Refraction();

        // Public accessor
        public static Refraction Instance => _instance;

        // Private constructor to prevent external instantiation
        private Refraction() : base(
            name: "Dimensional Refration Variant",
            riskLevel: RiskLevel.WAW,
            weapon: Refraction_Weapon.Instance,
            gift: Refraction_Gift.Instance
            )
        {
        }
    }
}