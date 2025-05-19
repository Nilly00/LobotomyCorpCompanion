namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Porccubus : AbnormalityOld
    {
        public Porccubus()
        {
            Name = "Porccubus";
            DerivedName = "Pleasure";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(SP:10,SR:-6,WS:-6));
        }
    }
}
