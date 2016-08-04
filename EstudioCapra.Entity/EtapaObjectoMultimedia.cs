namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EtapaObjectoMultimedia")]
    public partial class EtapaObjectoMultimedia
    {
        [Key]
        [Column(Order = 0)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EtapaId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectoMultimediaId { get; set; }

        public int? ObjetoMultimediaId { get; set; }

        public virtual Etapa Etapa { get; set; }

        public virtual ObjetoMultimedia ObjetoMultimedia { get; set; }
    }
}
