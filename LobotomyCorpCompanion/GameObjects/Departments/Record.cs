using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Record : Department
    {
        public Record()
        {
            Name = "Record Team";
            employees = new List<Employee>();
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
