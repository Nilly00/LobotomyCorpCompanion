using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LobotomyCorpCompanion.GameObjects.Departments;

namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Department
    {
        internal string Name;
        internal int employeeCap = 5;
        internal List<Employee> employees = new List<Employee>();
        internal int abnormalityCap = 4;
        internal List<Abnormality>? abnormalities;
        internal bool enabled = false;

        internal static readonly FrozenDictionary<string, Department> Departments = new Dictionary<string, Department>
        {
            {"Architecture Team",       new Architecture()  },
            {"Central Command Team",    new CentralCommand()},
            {"Control Team",            new Control()       },
            {"Disciplinary Team",       new Disciplinary()  },
            {"Extraction Team",         new Extraction()    },
            {"Information Team",        new Information()   },
            {"Record Team",             new Record()        },
            {"Safety Team",             new Safety()        },
            {"Trainign Team",           new Training()      },
            {"Welfare Team",            new Welfare()       },
            {"Bench",                   new Bench()         },
        }.ToFrozenDictionary();

        internal virtual void ClerkEffect(){}

        internal virtual void ServiceBenefits(Employee employee){}

        internal void AddEmployee(Employee employee)
        {
            if (employees.Count == employeeCap)
            {
                throw new Exception("Employee cap reached!");
            }
            else
            {

            }

        }

        internal void RemoveEmployee(Employee employee)
        {
            if (employees.Contains(employee))
            {
                employees.Remove(employee);
            }
            else
            {
                throw new Exception("Employee not found!");
            }
        }
    }
}
