﻿namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Bee_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Bee_Suit _instance = new Bee_Suit();

        // Public accessor
        public static Bee_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bee_Suit() : base(
            origin: Bee.Instance,
            name: "Hornet",
            cost: 50,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 3 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(0.7, 0.7, 0.7, 1.5)
            )
        {
        }
    }
}