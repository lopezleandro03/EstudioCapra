namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TareaEmpleado")]
    public partial class TareaEmpleado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TareaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpleadoId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Tarea Tarea { get; set; }
    }
}
