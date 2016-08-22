namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObjetoMultimedia")]
    public partial class ObjetoMultimedia
    {
        public int ObjetoMultimediaId { get; set; }

        [StringLength(50)]
        public string Servidor { get; set; }

        [StringLength(50)]
        public string Directorio { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }

        [Required]
        public byte[] DatosComprimidos { get; set; }

        public int? EtapaId { get; set; }

        public virtual Etapa Etapa { get; set; }
    }
}
