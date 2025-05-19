namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Firebird : AbnormalityOld
    {
        public Firebird()
        {
            Name = "The Firebird";
            DerivedName = "Feather of Honor";
            RiskLevel = RiskLevel.WAW;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:2,AS:4,MS:4));
        }
    }
}
