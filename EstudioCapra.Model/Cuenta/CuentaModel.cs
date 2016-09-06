using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCapra.Model.Cuenta
{
    public class CuentaModel
    {
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public decimal PagoMinimo { get; set; }
        public List<PagoModel> Pagos { get; set; }
        
    }
}
