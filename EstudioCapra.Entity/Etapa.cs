namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etapa")]
    public partial class Etapa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etapa()
        {
            ObjetoMultimedia = new HashSet<ObjetoMultimedia>();
            Tarea = new HashSet<Tarea>();
        }

        public int EtapaId { get; set; }

        public int ServicioId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(2000)]
        public string Descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        public decimal CostoBase { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFin { get; set; }

        public virtual Servicio Servicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjetoMultimedia> ObjetoMultimedia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarea> Tarea { get; set; }
    }
}
