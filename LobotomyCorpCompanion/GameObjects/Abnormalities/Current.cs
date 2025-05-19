namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Current : AbnormalityOld
    {
        public Current()
        {
            Name = "The Dreaming Current";
            DerivedName = "Ecstasy";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(SP:6));
        }
    }
}