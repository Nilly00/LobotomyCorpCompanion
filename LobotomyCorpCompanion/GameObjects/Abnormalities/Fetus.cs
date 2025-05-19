namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fetus : AbnormalityOld
    {
        public Fetus()
        {
            Name = "Nameless Fetus";
            DerivedName = "Syrinx";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:-2,SP:-2,AS:6,MS:6));
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.permanentBoni.resistances.white *= 0.95;
        }
    }
}
