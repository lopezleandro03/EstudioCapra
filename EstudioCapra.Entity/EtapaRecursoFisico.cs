namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EtapaRecursoFisico")]
    public partial class EtapaRecursoFisico
    {
        public int EtapaId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public int RecursoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public int? RecursoFisicoId { get; set; }

        public virtual RecursoFisico RecursoFisico { get; set; }
    }
}
