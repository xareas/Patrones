﻿namespace Patrones.VisitorAnimals
{
    public class Felino : Animal
    {
        public override void Accept(IAnimalVisitor visit)
        {
            visit.Visit(this);
        }
    }
}