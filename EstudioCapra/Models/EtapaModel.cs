using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudioCapra.Models
{
    public class EtapaModel
    {
          public int IdEtapa { get; set; }
          public string NombreEtapa { get; set; }
          public string DescripcionEtapa { get; set; }
          public DateTime FechaInicioEtapa { get; set; }
          public DateTime? FechaFinEtapa { get; set; }                                                
    }
}