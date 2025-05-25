namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Control : Department
    {
        // Singleton instance
        private static readonly Control _instance = new Control();

        // Public accessor
        public static Control Instance => _instance;

        // Private constructor to prevent external instantiation
        private Control() : base(name: "Control"){ }

        internal override void ClerkEffect()
        {
            Employee.globalBonuses.secondaryStats.MS += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBonuses.secondaryStats.MS += 10;
            }
            else if (employee.daysInService > 6)
            {
                employee.permanentBonuses.secondaryStats.MS += 7;
            }
            else if (employee.daysInService > 2)
            {
                employee.permanentBonuses.secondaryStats.MS += 5;
            }
            else
            {
                employee.permanentBonuses.secondaryStats.MS += 3;
            }
        }
    }
}