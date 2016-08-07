namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoServicio")]
    public partial class TipoServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoServicio()
        {
            Servicio = new HashSet<Servicio>();
        }

        public int TipoServicioId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string Atributo1 { get; set; }

        public string Atributo2 { get; set; }

        public string Atributo3 { get; set; }

        public string Atributo4 { get; set; }

        public string Atributo5 { get; set; }

        public string Atributo6 { get; set; }

        public string Atributo7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
