namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Control : Department
    {
        public Control()
        {
            Name = "Control Team";
            employees = new List<Employee>();
            abnormalities = new List<AbnormalityOld>();
            enabled = true;
        }
        internal override void ClerkEffect()
        {
            if (this.enabled)
            {
                Employee.globalBonuses.secondaryStats.MS += 5;
            }
        }
        internal override void ServiceBenefits(Employee employee)
        {
        }
    }
}
