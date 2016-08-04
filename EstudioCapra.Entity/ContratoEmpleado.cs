namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContratoEmpleado")]
    public partial class ContratoEmpleado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFin { get; set; }

        [Column(TypeName = "money")]
        public decimal Salario { get; set; }

        [Required]
        [StringLength(50)]
        public string ModoDePago { get; set; }

        [Column(TypeName = "date")]
        public DateTime DiaDePago { get; set; }

        public int? EmpleadoId { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
