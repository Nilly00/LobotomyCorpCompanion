namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fairy : AbnormalityOld
    {
        public Fairy()
        {
            Name = "Fairy Festival";
            DerivedName = "Wingbeat";
            RiskLevel = RiskLevel.ZAYIN;
            //Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SR:2,WS:2));
        }
    }
}
