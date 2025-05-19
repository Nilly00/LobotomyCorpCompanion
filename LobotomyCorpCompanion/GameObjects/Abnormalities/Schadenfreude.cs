namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Schadenfreude : AbnormalityOld
    {
        public Schadenfreude()
        {
            Name = "Schadenfreude";
            DerivedName = "Gaze";
            RiskLevel = RiskLevel.HE;
            //Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(HP:4));
        }

        /*internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While on screen JUSTICE +10 base Defense becomes 0.8/0.5/0.8/1.5");
            employee.conditionalBoni.primaryStats.Justice += 10;
            //todo special calculation for defense in employee method
        }*/
    }
}
