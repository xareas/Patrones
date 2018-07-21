namespace Patrones.FlyWeight
{
    public class RunMain
    {
        public static void Run()
        {
            var myFactory = new RobotFactory();
            IRobot myRobot = myFactory.GetFromFactory("Small");
            
        }





    }
}