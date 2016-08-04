namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecursoFisico")]
    public partial class RecursoFisico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecursoFisico()
        {
            EtapaRecursoFisico = new HashSet<EtapaRecursoFisico>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecursoFisicoId { get; set; }

        public int TipoRecursoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaAdquisicion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFinGarantia { get; set; }

        public string Especificaciones { get; set; }

        public int? TipoRecursoFisicoId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EtapaRecursoFisico> EtapaRecursoFisico { get; set; }
    }
}
