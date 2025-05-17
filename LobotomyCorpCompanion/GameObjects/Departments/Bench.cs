using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Bench : Department
    {
        public Bench()
        {
            Name = "Bench";
            employees = new List<Employee>();
        }

        internal override void ClerkEffect(){}
        internal override void ServiceBenefits(Employee employee){}
    }
}
