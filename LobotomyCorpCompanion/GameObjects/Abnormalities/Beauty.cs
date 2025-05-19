namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Beauty : AbnormalityOld
    {
        public Beauty()
        {
            Name = "Beauty and the Beast";
            DerivedName = "Horn";
            RiskLevel = RiskLevel.TETH;
            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2, SP:2));
        }
    }
}
