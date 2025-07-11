﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class OneSin_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly OneSin_Suit _instance = new();

        // Public accessor
        public static OneSin_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private OneSin_Suit() : base(
            origin: OneSin.Instance,
            name: "Penitence",
            unlockLevel: 2,

            cost: 10,
            maxCount: 5,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ZAYIN,

            resistances: new Resistances(0.9, 0.8, 0.9, 2.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Heal SP +10 with a 5% chance upon receiving RED or BLACK damage");
        }
    }
}