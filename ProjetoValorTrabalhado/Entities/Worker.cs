using ProjetoValorTrabalhado.Entities.Enums;


namespace ProjetoValorTrabalhado.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departent Departent { get; set; }
    }
}
