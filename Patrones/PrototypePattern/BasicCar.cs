namespace WebPatrones.PrototypePattern
{
    public abstract class BasicCar
    {
        protected string ModelName { get; set; }
        public decimal Precio { get; set; }
        public abstract BasicCar Clone();

        protected virtual string GetStatus()
        {
            return "Fabuloso";
        }
    }
}