namespace Patrones.AbstracFactory
{
    public class RunProgram
    {
        public static void Run()
        {
            IAnimalFactory wildFactory= new WildAnimalFactory();
            IAnimalFactory petFactory = new PetAnimalFactory();
            wildFactory.GetDog().Speak();
            petFactory.GetDog().Speak();
            
            
        }
    }
}