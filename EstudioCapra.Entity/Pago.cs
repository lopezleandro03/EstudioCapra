namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pago")]
    public partial class Pago
    {
        public int PagoId { get; set; }

        public int ClienteId { get; set; }

        [Column(TypeName = "money")]
        public decimal Monto { get; set; }

        public DateTime FechaDePago { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        [StringLength(200)]
        public string Motivo { get; set; }

        public int MetodoPagoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaRevision { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual MetodoPago MetodoPago { get; set; }
    }
}
