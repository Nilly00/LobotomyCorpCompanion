﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Cute_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Cute_Suit _instance = new();

        // Public accessor
        public static Cute_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cute_Suit() : base(
            origin: Cute.Instance,
            name: "SO CUTE!!!",
            unlockLevel: 3,

            cost: 20,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.8, 1.2, 0.8, 2.0)
            )
        {
        }
    }
}