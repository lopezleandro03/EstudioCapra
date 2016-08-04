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
        [Key]
        [Column(Order = 0)]
        public int TareaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoTareaId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4000)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime FechaFin { get; set; }

        public int? TareaPadreId { get; set; }

        public virtual TipoTarea TipoTarea { get; set; }
    }
}
