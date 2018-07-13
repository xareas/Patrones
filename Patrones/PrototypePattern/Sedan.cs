namespace WebPatrones.PrototypePattern
{
    public class Sedan :BasicCar
    {
        public Sedan(string modelo)
        {
            this.ModelName = modelo;
        }

        public override BasicCar Clone()
        {
            return (Sedan) this.MemberwiseClone();
        }
        
        
    }
}