using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCapra.Model.Cuenta
{
    public class PagoModel
    {
        public int PagoId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaDePago { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
        public string MetodoDePago { get; set; }
    }

}
