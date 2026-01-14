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
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.PrimaryStats += 5;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.PrimaryStats += 3;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.PrimaryStats += 2;
            }
            else
            {
                employee.PermanentBonuses.PrimaryStats += 1;
            }
        }
    }
}