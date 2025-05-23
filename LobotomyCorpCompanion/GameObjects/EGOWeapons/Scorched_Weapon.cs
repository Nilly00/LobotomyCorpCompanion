﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Scorched_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Scorched_Weapon _instance = new Scorched_Weapon();

        // Public accessor
        public static Scorched_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scorched_Weapon() : base(
            name: "Fourth MAtch Flame",
            cost: 35,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.TETH,
            damageMin: 20,
            damageMax: 30,
            range: 15,
            attackSpeed: 5.0)
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
