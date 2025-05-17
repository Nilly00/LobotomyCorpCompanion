using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Disciplinary : Department
    {
        public Disciplinary()
        {
            Name = "Disciplinary Team";
            employees = [];
            abnormalities = [];
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
