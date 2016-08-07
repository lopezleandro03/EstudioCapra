namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EtapaTarea")]
    public partial class EtapaTarea
    {
        public long id { get; set; }

        public int EtapaId { get; set; }

        public int TareaId { get; set; }

        public virtual Etapa Etapa { get; set; }

        public virtual Tarea Tarea { get; set; }
    }
}
