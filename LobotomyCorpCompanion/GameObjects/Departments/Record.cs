namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Record : Department
    {
        // Singleton instance
        private static readonly Record _instance = new();

        // Public accessor
        public static Record Instance => _instance;

        // Private constructor to prevent external instantiation
        private Record() : base(name: "Record"){ }

        internal override void ClerkEffect()
        {
            Employee.GlobalBonuses.PrimaryStats += 3;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.PrimaryStats += 6;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.PrimaryStats += 4;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.PrimaryStats += 3;
            }
            else
            {
                employee.PermanentBonuses.PrimaryStats += 2;
            }
        }
    }
}