namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Department
    {
        //unchanging
        internal string Name { get; init; }
        internal int EmployeeCap { get; init; } = 5;
        internal int AbnormalityCap { get; init; } = 4;
        //read from save
        internal bool enabled;

        //calculated at runtime
        internal List<Abnormality> Abnormalities { get; private set; } = [];
        internal List<Employee> Employees { get; private set; } = [];
        
        protected Department(string name,int employeeCap = 5,int abnormalityCap = 4)
        {
            this.Name = name;
            this.EmployeeCap = employeeCap;
            this.AbnormalityCap = abnormalityCap;
            if (Abnormalities.Count > 0)
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
        internal virtual void ServiceBenefits(Employee employee){}
        
        internal void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        internal void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
            if (employee.isCaptain)
            {
                DetermineCaptain();
            }
        }

        internal bool JobAvailable()
        {
            return ((this.EmployeeCap - this.Employees.Count) != 0);
        }
        internal bool CellAvailable()
        {
            return ((this.AbnormalityCap - this.Abnormalities.Count) != 0);
        }
        private void DetermineCaptain()
        {
            Employee captain = new();
            bool captainChanged = false;

            foreach (Employee employee in Employees)
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
