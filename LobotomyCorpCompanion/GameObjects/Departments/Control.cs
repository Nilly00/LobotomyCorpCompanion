using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Control : Department
    {
        public Control()
        {
            Name = "Control Team";
            employees = new List<Employee>();
            abnormalities = new List<Abnormality>();
            enabled = true;
        }
        internal override void ClerkEffect()
        {
            if (this.enabled)
            {
                Employee.globalBoni.secondaryStats.MS += 5;
            }
        }
        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBoni.secondaryStats.MS += 10;
            }
            else if (employee.daysInService >= 7)
            {
                employee.permanentBoni.secondaryStats.MS += 7;
            }
            else if (employee.daysInService >= 3)
            {
                employee.permanentBoni.secondaryStats.MS += 5;
            }
            else
            {
                employee.permanentBoni.secondaryStats.MS += 3;
            }
        }
    }
}
