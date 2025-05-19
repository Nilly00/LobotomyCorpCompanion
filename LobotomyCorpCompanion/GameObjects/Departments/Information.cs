namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Information : Department
    {
        public Information()
        {
            Name = "Information Team";
            employeeCap = 5;
            employees = new List<Employee>();
            abnormalityCap = 5;
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
