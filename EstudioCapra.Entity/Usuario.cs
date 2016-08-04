namespace EstudioCapra.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [Column(Order = 0)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Contraseña { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Telefono1 { get; set; }

        [StringLength(50)]
        public string Telefono2 { get; set; }
    }
}
