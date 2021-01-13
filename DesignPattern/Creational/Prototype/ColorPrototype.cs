using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype
{
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
