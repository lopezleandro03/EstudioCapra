namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemMenu")]
    public partial class ItemMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemMenu()
        {
            Rol = new HashSet<Rol>();
        }

        public int ItemMenuId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Orden { get; set; }

        public bool Estado { get; set; }

        public int? ItemMenuPadreId { get; set; }

        [StringLength(50)]
        public string Controlador { get; set; }

        [StringLength(50)]
        public string Accion { get; set; }

        [StringLength(500)]
        public string Parametros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rol> Rol { get; set; }
    }
}
