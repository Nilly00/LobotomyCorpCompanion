namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class White : AbnormalityOld
    {
        public White()
        {
            Name = "White Night";
            DerivedName = "Paradise Lost";
            RiskLevel = RiskLevel.ALEPH;


            Suit = new EgoSuit(DerivedName,333, 1, [5, 5, 5, 5, 5], RiskLevel, new Resistances(0.5, 0.5, 0.5, 0.3));

            //Gift = new EgoGift(DerivedName, Slot.Left_back, new SecondaryStats(HP:10,SP:10,AS:10,MS:10));
        }

        internal override void SuitEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
