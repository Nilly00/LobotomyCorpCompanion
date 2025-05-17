namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WellCheers : Abnormality
    {
        public WellCheers()
        {
            Name = "Opened Can of WellCheers";
            DerivedName = "Soda";
            RiskLevel = RiskLevel.ZAYIN;

            Weapon = new EgoWeapon(DerivedName, 20, 2, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 1, 2, 10, 0.7f);

            Suit = new EgoSuit(DerivedName, 15, 5, [0, 0, 0, 0, 0], RiskLevel, [0.8, 1.0, 1.0, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:2));
        }
    }
}