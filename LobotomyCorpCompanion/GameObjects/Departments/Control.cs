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
                employee.PermanentBonuses.secondaryStats.MS += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.secondaryStats.MS += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.secondaryStats.MS += 5;
            }
            else
            {
                employee.PermanentBonuses.secondaryStats.MS += 3;
            }
        }
    }
}