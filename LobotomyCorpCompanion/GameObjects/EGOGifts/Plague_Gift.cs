namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Plague_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Plague_Gift _instance = new();

        // Public accessor
        public static Plague_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Plague_Gift() : base(
            origin: Plague.Instance,
            name: "Bless",
            unlockLevel: 0,

            slot: Slot.Special,
            secondaryStats: new SecondaryStats(HP: 6, SP: 6, SR: 6, WS: 6, AS: 6, MS: 6)
        )
        { }

        internal override void Effect(Employee employee)
        {
            //employee.SpecialEffects.Add("𝔹𝕃𝔼𝕊𝕊𝔼𝔻");
            employee.SpecialEffects.Add("BLESSED");
        }
    }
}