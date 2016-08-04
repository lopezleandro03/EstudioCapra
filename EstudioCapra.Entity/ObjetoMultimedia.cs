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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjetoMultimedia()
        {
            EtapaObjectoMultimedia = new HashSet<EtapaObjectoMultimedia>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjetoMultimediaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Servidor { get; set; }

        [Required]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EtapaObjectoMultimedia> EtapaObjectoMultimedia { get; set; }
    }
}
