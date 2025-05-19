namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Punishing : AbnormalityOld
    {
        public Punishing()
        {
            Name = "Punishing Bird";
            DerivedName = "Beak";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, new Resistances(0.7, 0.8, 1.2, 2.0));

            //Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(AS:2,MS:2));
        }
    }
}
