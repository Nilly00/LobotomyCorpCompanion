﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Rabbit_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Rabbit_Weapon _instance = new();

        // Public accessor
        public static Rabbit_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rabbit_Weapon() : base(
            origin: Rabbit.Instance,
            name: "Standard Training E.G.O",
            unlockLevel: 4,

            cost: 1,
            maxCount: 5,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.WHITE, 
            damageMin: 5,
            damageMax: 7,
            range: 4,
            attackSpeed: 1.0)
        {
        }
    }
}
