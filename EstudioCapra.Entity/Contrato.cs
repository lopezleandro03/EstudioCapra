namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contrato")]
    public partial class Contrato
    {
        public int ContratoId { get; set; }

        public int ClienteId { get; set; }

        public int ServicioId { get; set; }

        [Column(TypeName = "money")]
        public decimal Costo { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFin { get; set; }

        [Column(TypeName = "money")]
        public decimal Saldo { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaCalculoSaldo { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Servicio Servicio { get; set; }
    }
}
