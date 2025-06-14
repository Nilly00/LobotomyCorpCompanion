﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Laetitia_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Laetitia_Weapon _instance = new();

        // Public accessor
        public static Laetitia_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Laetitia_Weapon() : base(
            origin: Laetitia.Instance,
            name: "Laetitia",
            unlockLevel: 4,

            cost: 40,
            maxCount: 2,
            requirements: [0, 2, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.BLACK, 
            damageMin: 5,
            damageMax: 6,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
