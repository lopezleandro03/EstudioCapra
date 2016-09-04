namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tarea")]
    public partial class Tarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarea()
        {
            TareaEmpleado = new HashSet<TareaEmpleado>();
        }

        public int TareaId { get; set; }

        public int EtapaId { get; set; }

        public int TipoTareaId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(4000)]
        public string Descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFin { get; set; }

        public int? TareaPadreId { get; set; }

        [Column(TypeName = "money")]
        public decimal Costo { get; set; }

        public virtual Etapa Etapa { get; set; }

        public virtual TipoTarea TipoTarea { get; set; }

        public int Horas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TareaEmpleado> TareaEmpleado { get; set; }
    }
}
