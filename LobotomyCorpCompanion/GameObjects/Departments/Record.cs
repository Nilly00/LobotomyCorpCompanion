namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Record : Department
    {
        public Record()
        {
            Name = "Record Team";
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
