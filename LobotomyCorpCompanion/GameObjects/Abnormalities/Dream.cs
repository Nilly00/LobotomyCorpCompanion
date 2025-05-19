namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Dream : AbnormalityOld
    {
        public Dream()
        {
            Name = "Void Dream";
            DerivedName = "Engulfing Dream";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:4));
        }
    }
}