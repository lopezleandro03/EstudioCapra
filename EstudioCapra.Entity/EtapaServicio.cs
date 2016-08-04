namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EtapaServicio")]
    public partial class EtapaServicio
    {
        public int id { get; set; }

        public int ServicioId { get; set; }

        public int EtapaId { get; set; }

        public virtual Etapa Etapa { get; set; }
    }
}
