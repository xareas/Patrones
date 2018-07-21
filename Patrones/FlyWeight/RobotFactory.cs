using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Patrones.FlyWeight
{
    public class RobotFactory
    {
        readonly Dictionary<string,IRobot> poolRobots = new Dictionary<string,IRobot>();

        public int TotalCreated => poolRobots.Count;

        public IRobot GetFromFactory(string robotype)
        {
            IRobot robotCategory = null;
            if (poolRobots.ContainsKey(robotype))
            {
                robotCategory = poolRobots[robotype];
            }
            else
            {
                switch (robotype)
                {
                        case "Small": 
                            robotCategory= new SmallRobot();
                            poolRobots.Add("Small",robotCategory);
                            break;
                        case "Large":
                            robotCategory = new LargeRobot();
                            poolRobots.Add("Large",robotCategory);
                            break;
                        default:
                            throw new  Exception("Tipo no reconocido");
                }
            }

            return robotCategory;
        }
    }
}