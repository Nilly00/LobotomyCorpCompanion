﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class White_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly White_Weapon _instance = new();

        // Public accessor
        public static White_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private White_Weapon() : base(
            origin: White.Instance,
            name: "Paradise Lost",
            unlockLevel: 0,

            cost: -1,
            maxCount: 1,
            requirements: [5, 5, 5, 5, 5],
            riskLevel: RiskLevel.ALEPH,

            type: DamageType.PALE,
            damageMin: 22,
            damageMax: 28,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            //todo special effect
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
