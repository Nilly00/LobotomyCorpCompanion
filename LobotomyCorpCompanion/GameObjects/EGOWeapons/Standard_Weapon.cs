namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Standard_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Standard_Weapon _instance = new Standard_Weapon();

        // Public accessor
        public static Standard_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Standard_Weapon() : base(
            name: "Standard Riot Stick",
            cost: -1,
            maxCount: -1,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.ZAYIN,
            damageMin: 4,
            damageMax: 6,
            range: 3,
            attackSpeed: 1.0)
        {
        }
    }
}
