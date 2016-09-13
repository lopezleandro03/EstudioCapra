using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCapra.Model.Cuenta
{
    public class CuentaModel
    {
        public string Saldo { get; set; }
        public string Total { get; set; }
        public string PagoMinimo { get; set; }
        public List<PagoModel> Pagos { get; set; }
        
    }
}
