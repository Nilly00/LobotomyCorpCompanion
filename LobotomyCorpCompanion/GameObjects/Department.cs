namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Department
    {
        //unchanging
        internal readonly string name;
        internal readonly int employeeCap = 5;
        internal readonly int abnormalityCap = 4;
        //read from save
        internal bool enabled;

        //calculated at runtime
        internal List<Abnormality> abnormalities = new List<Abnormality>();
        internal List<Employee> employees = new List<Employee>();

        internal static readonly FrozenDictionary<string, Department> list = new Dictionary<string, Department>
        {
            {"Architecture Team",       Architecture.Instance           },
            {"Central Command Team",    CentralCommand.Instance         },
            {"Control Team",            Control.Instance                },
            {"Disciplinary Team",       Disciplinary.Instance           },
            {"Extraction Team",         Extraction.Instance             },
            {"Information Team",        Information.Instance            },
            {"Record Team",             Record.Instance                 },
            {"Safety Team",             Safety.Instance                 },
            {"Trainign Team",           Training.Instance               },
            {"Welfare Team",            Welfare.Instance                },
            {"Bench",                   Bench.Instance                  },
        }.ToFrozenDictionary();
        protected Department(string name,int employeeCap = 5,int abnormalityCap = 4)
        {
            this.name = name;
            this.employeeCap = employeeCap;
            this.abnormalityCap = abnormalityCap;
            if (abnormalities.Count > 0)
            {
                this.enabled = true;
                this.ClerkEffect();
            }
            else
            {
                this.enabled = false;
            }
        }
        internal virtual void ClerkEffect(){}
        internal virtual void ServiceBenefits(Employee employee)
        {
        }
        //todo
        internal void AddEmployee(Employee employee)
        {
            employee.department.RemoveEmployee(employee);
            employees.Add(employee);
        }
        //todo
        internal void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            if (employee.isCaptain)
            {
                DetermineCaptain();
            }
        }

        private void DetermineCaptain()
        {
            Employee captain = new();
            bool captainChanged = false;

            foreach (Employee employee in employees)
            {
                if (employee.daysInService > 7 && employee.daysInService > captain.daysInService)
                {
                    captain = employee;
                    captainChanged = true;
                }
            }
            if (captainChanged)
            {
                captain.isCaptain = true;
                captain.Calculate();
            }
        }
    }
}
