namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OldLady : AbnormalityOld
    {
        public OldLady()
        {
            Name = "Old Lady";
            DerivedName = "Solitude";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:3,WS:3));
        }
    }
}
