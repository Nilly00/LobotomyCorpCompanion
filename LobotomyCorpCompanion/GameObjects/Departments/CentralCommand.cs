namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class CentralCommand : Department
    {
        // Singleton instance
        private static readonly CentralCommand _instance = new CentralCommand();

        // Public accessor
        public static CentralCommand Instance => _instance;

        // Private constructor to prevent external instantiation
        private CentralCommand() : base(name: "Central Command",employeeCap: 8,abnormalityCap: 8){ }


        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.primaryStats += 5;
            }
            else if (employee.daysInService > 6)
            {
                employee.PermanentBonuses.primaryStats += 3;
            }
            else if (employee.daysInService > 2)
            {
                employee.PermanentBonuses.primaryStats += 2;
            }
            else
            {
                employee.PermanentBonuses.primaryStats += 1;
            }
        }
    }
}