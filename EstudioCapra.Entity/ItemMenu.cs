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
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemMenuId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Orden { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Estado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemMenuPadreId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Controlador { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Accion { get; set; }

        [StringLength(500)]
        public string Parametros { get; set; }
    }
}
