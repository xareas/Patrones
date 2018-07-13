namespace WebPatrones.PrototypePattern
{
    public class RunPrototype
    {
        public void MainExecutePattern()
        {
            var modelobase = new Camioneta("hilux");
            BasicCar carro = modelobase.Clone();
            var carroProfundo = modelobase.DeepClone();
            

        }
    }
}