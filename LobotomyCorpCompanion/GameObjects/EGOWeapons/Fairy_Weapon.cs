namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Fairy_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Fairy_Weapon _instance = new Fairy_Weapon();

        // Public accessor
        public static Fairy_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fairy_Weapon() : base(
            origin: Fairy.Instance,
            name: "Wingbeat",
            unlockLevel: 3,
            cost: 10,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.ZAYIN,
            damageMin: 5,
            damageMax: 7,
            range: 3,
            attackSpeed: 2.0)
        {
        }
    }
}
