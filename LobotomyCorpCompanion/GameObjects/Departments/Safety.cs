namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Safety : Department
    {
        public Safety()
        {
            Name = "Safety Team";
            employees = new List<Employee>();
            abnormalities = new List<AbnormalityOld>();
        }
        internal override void ClerkEffect()
        {
            // todo effect
        }
        internal override void ServiceBenefits(Employee employee)
        {
        }
    }
}
