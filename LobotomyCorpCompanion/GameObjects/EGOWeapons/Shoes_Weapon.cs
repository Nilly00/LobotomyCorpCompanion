﻿namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Shoes_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Shoes_Weapon _instance = new Shoes_Weapon();

        // Public accessor
        public static Shoes_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shoes_Weapon() : base(
            name: "Sanguine Desire",
            cost: 40,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.HE,
            damageMin: 4,
            damageMax: 7,
            range: 2,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.ranks[2] > 3)
            {
                employee.permanentBoni.damageFlat += 4;
                employee.SpecialEffects.Add("take SP damage equal to 4% of Max. SP on each attack");
            }
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
