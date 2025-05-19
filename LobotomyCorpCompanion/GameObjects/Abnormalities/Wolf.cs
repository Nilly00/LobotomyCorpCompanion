namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Wolf : AbnormalityOld
    {
        public Wolf()
        {
            Name = "The Big and Will be Bad Wolf";
            DerivedName = "Cobalt Scar";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Face, new SecondaryStats(HP:4,AS:2,MS:2));
        }
    }
}
