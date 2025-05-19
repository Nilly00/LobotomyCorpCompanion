namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Freischütz : AbnormalityOld
    {
        public Freischütz()
        {
            Name = "Der Freischütz";
            DerivedName = "Magic Bullet";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:-5,SP:-5,AS:10,MS:10));
        }

        internal override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.damageFlat += 3;
            }
        }*/
    }
}
