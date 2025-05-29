namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Disciplinary : Department
    {
        // Singleton instance
        private static readonly Disciplinary _instance = new();

        // Public accessor
        public static Disciplinary Instance => _instance;

        // Private constructor to prevent external instantiation
        private Disciplinary() : base(name: "Disciplinary"){ }

        internal override void ClerkEffect()
        {
            Employee.globalBonuses.secondaryStats.AS += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.damagePercent *= 1.2;
            }
            else if (employee.daysInService > 6)
            {
                employee.PermanentBonuses.damagePercent *= 1.1;
            }
            else if (employee.daysInService > 2)
            {
                employee.PermanentBonuses.damagePercent *= 1.06;
            }
            else
            {
                employee.PermanentBonuses.damagePercent *= 1.03;
            }
        }
    }
}