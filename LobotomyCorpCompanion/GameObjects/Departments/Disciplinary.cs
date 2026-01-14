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
            Employee.GlobalBonuses.SecondaryStats.AS += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.DamagePercent *= 1.2;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.DamagePercent *= 1.1;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.DamagePercent *= 1.06;
            }
            else
            {
                employee.PermanentBonuses.DamagePercent *= 1.03;
            }
        }
    }
}