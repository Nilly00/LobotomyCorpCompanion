namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Army : AbnormalityOld
    {
        public Army()
        {
            Name = "Army in Black";
            DerivedName = "Pink";
            RiskLevel = RiskLevel.ALEPH;
            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(AS:5, MS:5));
        }
            /*if (employee.weapon == this)
            {
                employee.permanentBoni.damagePercent *= 1.15;
            }*/
    }
}
