﻿namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Judgement_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Judgement_Gift _instance = new();

        // Public accessor
        public static Judgement_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Judgement_Gift() : base(
            origin: Judgement.Instance,
            name: "Justitia",
            unlockLevel: 3,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(AS: 3, MS: 3)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("REPRESSION SR +6%");
            employee.SpecialEffects.Add("Immune to Firebird's Blind effect");
        }
    }
}