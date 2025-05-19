namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Refraction : AbnormalityOld
    {
        public Refraction()
        {
            Name = "Dimensional Refraction Variant";
            DerivedName = "Diffraction";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(SP:6));
        }
    }
}
