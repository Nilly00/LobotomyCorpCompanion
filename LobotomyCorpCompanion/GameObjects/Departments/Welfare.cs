using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Welfare : Department
    {
        public Welfare()
        {
            Name = "Welfare Team";
            employees = new List<Employee>();
            abnormalities = new List<Abnormality>();
        }
        internal override void ServiceBenefits(Employee employee)
        {
            //todo figure out how the defense increase works
        }
    }
}
