namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apocalypse : AbnormalityOld
    {
        public Apocalypse()
        {
            Name = "Apocalypse Bird";
            DerivedName = "Twilight";
            RiskLevel = RiskLevel.ALEPH;

            //Gift = new EgoGift("Through the Dark Twilight", Slot.Right_back, new SecondaryStats(7, 7, 7, 7, 7, 7));
        }
    }
}
