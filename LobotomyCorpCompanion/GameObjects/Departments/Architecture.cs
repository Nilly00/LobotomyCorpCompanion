namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Architecture : Department
    {
        public Architecture()
        {
            Name = "Architecture Team";
            employees = new List<Employee>();
            abnormalityCap = 8;
            abnormalities = new List<AbnormalityOld>();
        }
        internal override void ClerkEffect(){}
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
