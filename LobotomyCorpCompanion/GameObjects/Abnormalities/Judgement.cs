namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Judgement : AbnormalityOld
    {
        public Judgement()
        {
            Name = "Judgement Bird";
            DerivedName = "Justitia";
            RiskLevel = RiskLevel.WAW;

            Suit = new EgoSuit(DerivedName, 120, 1, [0, 0, 0, 5, 5], RiskLevel.ALEPH, new Resistances(0.5, 0.5, 0.5, 0.5));

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(AS:3,MS:3));
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("REPRESSION SR +6%");
            //immune to fire bird's blind
        }
    }
}
