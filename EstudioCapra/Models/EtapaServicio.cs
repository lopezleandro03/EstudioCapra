//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstudioCapra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EtapaServicio
    {
        public int id { get; set; }
        public int ServicioId { get; set; }
        public int EtapaId { get; set; }
        public virtual Etapa Etapa { get; set; }
    }
}
