namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Monk : AbnormalityOld
    {
        public Monk()
        {
            Name = "Clouded Monk";
            DerivedName = "Amita";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Hand_1, new SecondaryStats(HP:10,SP:-4));
        }
    }
}
