namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shoes : AbnormalityOld
    {
        public Shoes()
        {
            Name = "The Red Shoes";
            DerivedName = "Sanguine Desire";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:4));
        }

        /*internal override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.secondaryStats.SR -= 10;
                employee.permanentBoni.secondaryStats.WS -= 10;
                employee.permanentBoni.secondaryStats.AS += 10;
            }
        }*/
    }
}
