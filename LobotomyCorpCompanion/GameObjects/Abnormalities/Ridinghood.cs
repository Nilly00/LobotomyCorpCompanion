namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Ridinghood : AbnormalityOld
    {
        public Ridinghood()
        {
            Name = "Litle Red Riding Hood";
            DerivedName = "Crimson Scar";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_1, new SecondaryStats(HP:3,AS:3,WS:3));
        }
    }
}
