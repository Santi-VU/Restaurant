using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interfaces
{
    interface IMaquinaable
    {
        public void SumarCaja(decimal founds);

        public decimal VerCaja();
    }
}
