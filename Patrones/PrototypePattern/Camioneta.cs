using System;

namespace WebPatrones.PrototypePattern
{
    public class Camioneta : BasicCar
    {
        public Camioneta(string modelo)
        {
            this.ModelName = modelo;
        }

        public override BasicCar Clone()
        {
          return   (Camioneta) this.MemberwiseClone();
        }

        protected override string GetStatus()
        {
            return "En Produccion";
        }
    }
}