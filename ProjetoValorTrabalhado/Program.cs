using System;
using ProjetoValorTrabalhado.Entities.Enums;
using System.Globalization;
using ProjetoValorTrabalhado.Entities;

namespace ProjetoValorTrabalhado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string departName = Console.ReadLine();
            Console.WriteLine("Entre com a data de trabalho ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nivel (Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salarial: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(departName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para esse trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com a data do #{i} contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração de horas: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(data, valuePerHour, hours);
                worker.AddContract(contract);

            }
            Console.WriteLine();
            Console.Write("Entre com o mês e ano para cacular o ganho no formato (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + worker.Name );
            Console.WriteLine("Departamento: " + worker.Departent.Name );
            Console.WriteLine("Ganhos no mes " + monthAndYear +": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
