namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bald : AbnormalityOld
    {
        public Bald()
        {
            Name = "You're Bald...";
            DerivedName = "Tough";
            RiskLevel = RiskLevel.ZAYIN;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(AS:2, MS:2));
        }
    }
}
