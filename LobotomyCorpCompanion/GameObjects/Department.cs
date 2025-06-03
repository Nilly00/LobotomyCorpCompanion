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
        internal readonly List<Abnormality> abnormalities = [];
        private readonly List<Employee> employees = [];
        
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
        
        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        
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
                if (employee.DaysInService > 7 && employee.DaysInService > captain.DaysInService)
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
