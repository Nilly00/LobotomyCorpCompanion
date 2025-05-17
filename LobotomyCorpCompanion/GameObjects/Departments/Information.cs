using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Information : Department
    {
        public Information()
        {
            Name = "Information Team";
            employeeCap = 5;
            employees = new List<Employee>();
            abnormalityCap = 5;
            abnormalities = new List<Abnormality>();
        }
        internal override void ClerkEffect(Employee employee)
        {
            // todo effect
        }
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
