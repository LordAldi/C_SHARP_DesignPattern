using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.AbstractFactory
{
    class Wolf:Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +" eats " + h.GetType().Name);
        }
    }
}
