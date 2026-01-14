namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OneSin : Abnormality
    {
        // Singleton instance
        private static readonly OneSin _instance = new();

        // Public accessor
        public static OneSin Instance => _instance;

        // Private constructor to prevent external instantiation
        private OneSin() : base(
            name: "One Sin and Hundreds of Good Deeds",
            riskLevel: RiskLevel.ZAYIN,
            weapon: OneSin_Weapon.Instance,
            suit: OneSin_Suit.Instance,
            gift: OneSin_Gift.Instance
            )
        {
            Unlocked = true;
            Department = Control.Instance;
        }
    }
}
