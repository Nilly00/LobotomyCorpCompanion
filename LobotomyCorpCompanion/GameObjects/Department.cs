namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Department
    {
        //unchanging
        internal string Name;
        internal int employeeCap = 5;
        internal int abnormalityCap = 4;
        //read from array
        internal bool enabled;
        //calculated at runtime
        internal List<Abnormality>? abnormalities = new List<Abnormality>();
        internal List<Employee>? employees = new List<Employee>();

        internal static readonly FrozenDictionary<string, Department> Departments = new Dictionary<string, Department>
        {
            {"Architecture Team",       Architecture.Instance           },
            {"Central Command Team",    CentralCommand.Instance         },
            {"Control Team",            Control.Instance                },
            {"Disciplinary Team",       Disciplinary.Instance           },
            {"Extraction Team",         Extraction.Instance             },
            {"Information Team",        Information.Instance            },
            {"Record Team",             Record.Instance                 },
            {"Safety Team",             Safety.Instance                 },
            {"Trainign Team",           Department.Training.Instance    },
            {"Welfare Team",            Welfare.Instance                },
            {"Bench",                   Bench.Instance                  },
        }.ToFrozenDictionary();


        protected Department(
            string name,
            int employeeCap = 5,
            int abnormalityCap = 4,
            bool enabled = false
            )
        {
            this.Name = name;
            this.employeeCap = employeeCap;
            this.abnormalityCap = abnormalityCap;
            this.enabled = enabled;
        }

        internal virtual void ClerkEffect(){}

        internal virtual void ServiceBenefits(Employee employee){}

        //todo
        internal void AddEmployee(Employee employee)
        {
            
        }

        //todo
        internal void RemoveEmployee(Employee employee)
        {
            //todo
        }
    }
}
