namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class CentralCommand : Department
    {
        public CentralCommand()
        {
            Name = "Central Command Team";
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
