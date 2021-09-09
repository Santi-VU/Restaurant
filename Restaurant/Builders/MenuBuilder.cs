using Restaurant.Interfaces;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Builders
{
    class MenuBuilder : IMenuable
    {
        public CarnivoroBuilder CarnivoroBuilder;
        public VeganoBuilder VeganoBuilder;
        public InfantilBuilder InfantilBuilder;
        public CeliacoBuilder CeliacoBuilder;

        public MenuBuilder() {
            this.CarnivoroBuilder = new CarnivoroBuilder();
            this.VeganoBuilder = new VeganoBuilder();
            this.InfantilBuilder = new InfantilBuilder();
            this.CeliacoBuilder = new CeliacoBuilder();
        }

        public CarnivoroBuilder setCarnivoroMenu()
        {
            return this.CarnivoroBuilder;
        }

        public CeliacoBuilder setCeliacoMenu()
        {
            return this.CeliacoBuilder;
        }

        public InfantilBuilder setInfantilMenu()
        {
            return this.InfantilBuilder;
        }

        public VeganoBuilder setVeganoMenu()
        {
            return this.VeganoBuilder;
        }
    }
}
