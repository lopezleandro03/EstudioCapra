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
    
    public partial class TipoServicio
    {
        public TipoServicio()
        {
            this.Servicios = new HashSet<Servicio>();
        }
    
        public int TipoServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Atributo1 { get; set; }
        public string Atributo2 { get; set; }
        public string Atributo3 { get; set; }
        public string Atributo4 { get; set; }
        public string Atributo5 { get; set; }
        public string Atributo6 { get; set; }
        public string Atributo7 { get; set; }
    
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
