﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Butterflies_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Butterflies_Weapon _instance = new Butterflies_Weapon();

        // Public accessor
        public static Butterflies_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Butterflies_Weapon() : base(
            name: "Solemn Lament",
            cost: 50,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 3, 0 },
            type: DamageType.BLACK_WHITE,
            riskLevel: RiskLevel.HE,
            damageMin: 2,
            damageMax: 2,
            range: 10,
            attackSpeed: 0.5)
        {
        }

        internal override void WeaponCalculate()
        {       
            //todo special calculation
            //dual
        }
    }
}
