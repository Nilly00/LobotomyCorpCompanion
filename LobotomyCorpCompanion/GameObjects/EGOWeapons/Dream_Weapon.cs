﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Dream_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Dream_Weapon _instance = new();

        // Public accessor
        public static Dream_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream_Weapon() : base(
            origin: Dream.Instance,
            name: "Engulfing Dream",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.WHITE, 
            damageMin: 1,
            damageMax: 2,
            range: 8,
            attackSpeed: 1.0)
        {
        }
    }
}
