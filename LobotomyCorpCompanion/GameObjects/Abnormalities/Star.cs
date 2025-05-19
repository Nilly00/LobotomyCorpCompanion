namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Star : AbnormalityOld
    {
        public Star()
        {
            Name = "Blue Star";
            DerivedName = "Sound of a Star";
            RiskLevel = RiskLevel.ALEPH;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(MS:10));
        }
    }
}
