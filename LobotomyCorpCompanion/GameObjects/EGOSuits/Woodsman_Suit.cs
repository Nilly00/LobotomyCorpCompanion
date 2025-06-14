﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Woodsman_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Woodsman_Suit _instance = new();

        // Public accessor
        public static Woodsman_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman_Suit() : base(
            origin: Woodsman.Instance,
            name: "Logging",
            unlockLevel: 3,

            cost: 30,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(0.8, 1.2, 0.8, 1.5)
            )
        {
        }
        internal override void Effect(Employee employee)
        {
        }
    }
}