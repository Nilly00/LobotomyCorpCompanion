namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Censored : AbnormalityOld
    {
        public Censored()
        {
            Name = "CENSORED";
            DerivedName = "CENSORED";
            RiskLevel = RiskLevel.ALEPH;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SP:10));
        }
    }
}
