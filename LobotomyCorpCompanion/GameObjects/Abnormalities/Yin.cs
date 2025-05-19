namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Yin : AbnormalityOld
    {
        public Yin()
        {
            Name = "Yin";
            DerivedName = "Discord";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:-10,SP:-10,AS:20,MS:20));
        }
    }
}
