﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Hatred_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Hatred_Suit _instance = new();

        // Public accessor
        public static Hatred_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Hatred_Suit() : base(
            origin: Hatred.Instance,
            name: "In the Name of Love and Hate",
            unlockLevel: 4,

            cost: 60,
            maxCount: 1,
            requirements: [0, 3, 3, 0, 4],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.7, 0.8, 0.4, 2.0)
            )
        {
        }
    }
}