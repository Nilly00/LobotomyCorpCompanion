namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Training : Department
    {
        public Training()
        {
            Name = "Training Team";
            employees = new List<Employee>();
            abnormalities = new List<AbnormalityOld>();
        }
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
