﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Cherry_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Cherry_Weapon _instance = new Cherry_Weapon();

        // Public accessor
        public static Cherry_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cherry_Weapon() : base(
            name: "Cherry Blossoms",
            cost: 25,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 1,
            damageMax: 2,
            range: 5,
            attackSpeed: 1.0)
        {
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
