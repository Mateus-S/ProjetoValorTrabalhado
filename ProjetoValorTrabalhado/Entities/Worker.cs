using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ProjetoValorTrabalhado.Entities.Enums;


namespace ProjetoValorTrabalhado.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Departent { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departent)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departent = departent;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }
        
        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();

                }

            }
            return sum;
        }
    }
}
