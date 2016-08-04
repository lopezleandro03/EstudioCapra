namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoRecursoFisico")]
    public partial class TipoRecursoFisico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoRecursoFisicoId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nombre { get; set; }

        public string Atributo1 { get; set; }

        public string Atributo2 { get; set; }

        public string Atrbuto3 { get; set; }

        public string Atributo4 { get; set; }

        public string Atributo5 { get; set; }
    }
}
