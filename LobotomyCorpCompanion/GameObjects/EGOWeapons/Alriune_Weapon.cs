﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Alriune_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Alriune_Weapon _instance = new();

        // Public accessor
        public static Alriune_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Alriune_Weapon() : base(
            origin: Alriune.Instance,
            name: "Faint Aroma",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [0, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE,
            damageMin: 10,
            damageMax: 20,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
