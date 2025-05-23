﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Yin_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Yin_Weapon _instance = new Yin_Weapon();

        // Public accessor
        public static Yin_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Yin_Weapon() : base(
            name: "Discord",
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 0, 0, 3, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.WAW,
            damageMin: 8,
            damageMax: 13,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
