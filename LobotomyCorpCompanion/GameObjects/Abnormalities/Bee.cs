namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bee : AbnormalityOld
    {

        public Bee()
        {
            Name = "Queen Bee";
            DerivedName = "Hornet";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2, SP: 4));
        }
    }
}
