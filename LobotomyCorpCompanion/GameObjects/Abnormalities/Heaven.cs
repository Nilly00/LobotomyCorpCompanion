namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Heaven : AbnormalityOld
    {
        public Heaven()
        {
            Name = "The Burrowing Heaven";
            DerivedName = "Heaven";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:4,SR:2,WS:2));
        }
    }
}
