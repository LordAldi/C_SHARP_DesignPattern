using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.AbstractFactory
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            //Eat wildebeest
            Console.WriteLine(this.GetType().Name + " Eats " + h.GetType().Name);
        }
    }
}
