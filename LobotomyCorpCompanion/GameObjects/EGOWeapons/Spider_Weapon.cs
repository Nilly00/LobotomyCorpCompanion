﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Spider_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Spider_Weapon _instance = new();

        // Public accessor
        public static Spider_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Spider_Weapon() : base(
            origin: Spider.Instance,
            name: "Red Eyes",
            unlockLevel: 3,

            cost: 20,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED,
            damageMin: 7,
            damageMax: 9,
            range: 3,
            attackSpeed: 2.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.Ranks[0] < 1)
            {
                employee.SpecialEffects.Add("+2.5 MS during supression or combat");
                employee.ConditionalBonuses.secondaryStats.MS += 2;
            }
        }
    }
}
