﻿namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Extraction : Department
    {
        // Singleton instance
        private static readonly Extraction _instance = new Extraction();

        // Public accessor
        public static Extraction Instance => _instance;

        // Private constructor to prevent external instantiation
        private Extraction() : base(name: "Extraction"){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBonuses.attackSpeedPercent *= 1.2;
                employee.permanentBonuses.resistances += 0.2;
            }
            else if (employee.daysInService > 6)
            {
                employee.permanentBonuses.attackSpeedPercent *= 1.1;
                employee.permanentBonuses.resistances += 0.1;
            }
            else if (employee.daysInService > 2)
            {
                employee.permanentBonuses.attackSpeedPercent *= 1.06;
                employee.permanentBonuses.resistances += 0.06;
            }
            else
            {
                employee.permanentBonuses.attackSpeedPercent *= 1.03;
                employee.permanentBonuses.resistances += 0.03;
            }
        }
    }
}