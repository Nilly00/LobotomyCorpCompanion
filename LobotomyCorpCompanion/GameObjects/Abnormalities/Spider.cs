namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Spider : AbnormalityOld
    {
        public Spider()
        {
            Name = "Spider Bud";
            DerivedName = "Red Eyes";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 30, 1, [2, 0, 0, 0, 0], RiskLevel, new Resistances(0.8, 0.8, 0.8, 2.0));

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:3,WS:3));
        }
    }
}
