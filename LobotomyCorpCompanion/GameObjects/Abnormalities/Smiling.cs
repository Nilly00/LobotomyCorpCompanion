namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Smiling : AbnormalityOld
    {
        public Smiling()
        {
            Name = "Mountain of Smiling Bodies";
            DerivedName = "Smile";
            RiskLevel = RiskLevel.ALEPH;
            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(HP: 5, SP: 5));
        }
    }
}
