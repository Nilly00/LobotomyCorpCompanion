﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Nest_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Nest_Suit _instance = new();

        // Public accessor
        public static Nest_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Suit() : base(
            origin: Nest.Instance,
            name: "Exuviae",
            unlockLevel: 4,

            cost: 50,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 3],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.6, 0.8, 1.2, 1.5)
            )
        {
        }
    }
}