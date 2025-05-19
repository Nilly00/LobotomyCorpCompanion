namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Nest : AbnormalityOld
    {
        public Nest()
        {
            Name = "The Naked Nest";
            DerivedName = "Exuviae";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(HP:5,SP:2));
        }
    }
}
