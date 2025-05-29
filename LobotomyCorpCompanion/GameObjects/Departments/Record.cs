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
            Employee.globalBonuses.primaryStats += 3;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.primaryStats += 6;
            }
            else if (employee.daysInService > 6)
            {
                employee.PermanentBonuses.primaryStats += 4;
            }
            else if (employee.daysInService > 2)
            {
                employee.PermanentBonuses.primaryStats += 3;
            }
            else
            {
                employee.PermanentBonuses.primaryStats += 2;
            }
        }
    }
}