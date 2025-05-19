namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cherry : AbnormalityOld
    {
        public Cherry()
        {
            Name = "Grave of Cherry Blossoms";
            DerivedName = "Cherry Blossoms";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2,AS:2,MS:2));
        }
    }
}
