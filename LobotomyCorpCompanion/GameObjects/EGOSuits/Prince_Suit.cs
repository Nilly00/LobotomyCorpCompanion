﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Prince_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Prince_Suit _instance = new Prince_Suit();

        // Public accessor
        public static Prince_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Prince_Suit() : base(
            origin: Prince.Instance,
            name: "Spore",
            cost: 50,
            maxCount: 3,
            requirements: new int[] { 0, 2, 0, 0, 2 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(0.8, 0.6, 1.2, 1.5)
            )
        {
        }
    }
}