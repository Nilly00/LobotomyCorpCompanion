namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Prince : AbnormalityOld
    {
        public Prince()
        {
            Name = "The Little Prince";
            DerivedName = "Spore";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SP:5,SR:2,WS:2));
        }
    }
}
