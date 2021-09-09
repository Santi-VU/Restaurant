using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interfaces
{
    interface IMesaable
    {
        public void AddMenu(Menu menu);

        public decimal CalcularCuenta();
    }
}
