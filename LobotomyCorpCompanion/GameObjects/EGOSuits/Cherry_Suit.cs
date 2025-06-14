﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Cherry_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Cherry_Suit _instance = new();

        // Public accessor
        public static Cherry_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cherry_Suit() : base(
            origin: Cherry.Instance,
            unlockLevel: 3,
            name: "Cherry Blossoms",

            cost: 30,
            maxCount: 1,
            requirements: [0, 2, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(1.2, 0.6, 0.7, 2.0)
            )
        {
        }
    }
}