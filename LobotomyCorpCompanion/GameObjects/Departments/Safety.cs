using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Safety : Department
    {
        public Safety()
        {
            Name = "Safety Team";
            employees = new List<Employee>();
            abnormalities = new List<Abnormality>();
        }
        internal override void ClerkEffect()
        {
            // todo effect
        }
        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBoni.primaryStats.Fortitude += 10;
                employee.permanentBoni.primaryStats.Prudence  += 10;
            }
            else if (employee.daysInService >= 7)
            {
                employee.permanentBoni.primaryStats.Fortitude += 7;
                employee.permanentBoni.primaryStats.Prudence  += 7;
            }
            else if (employee.daysInService >= 3)
            {
                employee.permanentBoni.primaryStats.Fortitude += 5;
                employee.permanentBoni.primaryStats.Prudence  += 5;
            }
            else
            {
                employee.permanentBoni.primaryStats.Fortitude += 3;
                employee.permanentBoni.primaryStats.Prudence  += 3;
            }
        }
    }
}
