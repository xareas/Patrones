namespace Patrones.Composite
{
    public class RunMain
    {
        public static void Run()
        {
            var composite = new CompositeEmployee("root","root");
            composite.AddEmployee(new Employee("Juan","Math"));
            composite.AddEmployee(new Employee("Jose","Ciencia"));
            var item = new Employee("Carlos","Math");
            composite.AddEmployee(item);
            
            item.PrintEstructura();
            composite.PrintEstructura();
            
        }
    }
}