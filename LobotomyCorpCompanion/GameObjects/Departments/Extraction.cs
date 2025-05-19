namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Extraction : Department
    {
        public Extraction()
        {
            Name = "Extraction Team";
            employees = new List<Employee>();
            abnormalities = new List<AbnormalityOld>();
        }
        internal override void ClerkEffect()
        {
            // todo effect
        }
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
