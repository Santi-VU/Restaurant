using Restaurant.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interfaces
{
    interface IMenuable
    {
        public CarnivoroBuilder setCarnivoroMenu();
        public VeganoBuilder setVeganoMenu();
        public InfantilBuilder setInfantilMenu();
        public CeliacoBuilder setCeliacoMenu();
    }
}
