using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class CentralCommand : Department
    {
        public CentralCommand()
        {
            Name = "Central Command Team";
            employees = new List<Employee>();
            abnormalityCap = 8;
            abnormalities = new List<Abnormality>();
        }
        internal override void ClerkEffect(){}
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
