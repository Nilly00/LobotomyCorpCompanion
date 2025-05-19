namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shy : AbnormalityOld
    {
        public Shy()
        {
            Name = "Today's Shy look";
            DerivedName = "Today's Expression";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 30, 1, [2, 0, 0, 0, 0], RiskLevel, new Resistances(0.7, 0.6, 1.5, 2.0));

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SP:-2,SR:4,WS:4));
        }
    }
}
