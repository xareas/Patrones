using System;

namespace WebPatrones.BuilderPattern
{
    public class RunBuilder
    {
        public static void RunMain()
        {
           Director director = new Director();
           
           IBuilder b1 = new Carro();
           IBuilder b2 = new  MotorCycle();
          
           director.Construct(b1);
           director.Construct(b2);
            
           var vehiculo = b1.GetVehicle();
           var vehiculo2 = b2.GetVehicle();
        }
    }
}