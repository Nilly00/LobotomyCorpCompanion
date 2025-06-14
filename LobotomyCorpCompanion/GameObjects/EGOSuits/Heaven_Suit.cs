﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Heaven_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Heaven_Suit _instance = new();

        // Public accessor
        public static Heaven_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Heaven_Suit() : base(
            origin: Heaven.Instance,
            name: "Heaven",
            unlockLevel: 3,

            cost: 50,
            maxCount: 2,
            requirements: [3, 0, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(1.2, 0.8, 0.6, 1.5)
            )
        {
        }
    }
}