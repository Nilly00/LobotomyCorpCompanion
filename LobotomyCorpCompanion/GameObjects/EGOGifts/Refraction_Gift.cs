﻿namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Refraction_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Refraction_Gift _instance = new();

        // Public accessor
        public static Refraction_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Refraction_Gift() : base(
            origin: Refraction.Instance,
            unlockLevel: 3,
            name: "Diffraction",

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(SP: 6)
        )
        { }
    }
}