﻿namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Lantern_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Lantern_Gift _instance = new();

        // Public accessor
        public static Lantern_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Lantern_Gift() : base(
            origin: Lantern.Instance,
            name: "Lantern",
            unlockLevel: 2,

            slot: Slot.Mouth_2,
            secondaryStats: new SecondaryStats(HP: 5)
        )
        { }
    }
}