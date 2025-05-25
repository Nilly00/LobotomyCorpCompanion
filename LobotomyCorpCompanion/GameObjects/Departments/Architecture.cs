namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Architecture : Department
    {
        // Singleton instance
        private static readonly Architecture _instance = new Architecture();

        // Public accessor
        public static Architecture Instance => _instance;

        // Private constructor to prevent external instantiation
        private Architecture() : base(name: "Architecture",employeeCap: 8,abnormalityCap: 8){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBonuses.primaryStats += 7;
            }
            else if (employee.daysInService > 6)
            {
                employee.permanentBonuses.primaryStats  += 5;
            }
            else if (employee.daysInService > 2)
            {
                employee.permanentBonuses.primaryStats  += 4;
            }
            else
            {
                employee.permanentBonuses.primaryStats  += 3;
            }
        }
    }
}