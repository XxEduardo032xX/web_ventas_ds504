using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_cliente")]
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo del cliente")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "Codigo Cliente")]
        public String codigo_cliente { get; set; }

        [Required(ErrorMessage = "Escriba nombre")]
        [StringLength(20)]
        [Display(Name = "Nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Escriba apellido materno")]
        [StringLength(20)]
        [Display(Name = "Apellido Materno")]
        public String ap_materno { get; set; }

        [Required(ErrorMessage = "Escriba apellido paterno")]
        [StringLength(20)]
        [Display(Name = "Apellido Paterno")]
        public String ap_paterno { get; set; }

        [Required(ErrorMessage = "Elija fecha de nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }

        [Required(ErrorMessage = "Escriba Direccion")]
        [StringLength(50)]
        [Display(Name = "Dirección")]
        public String direccion { get; set; }

        [Required(ErrorMessage = "Escriba correo electronico")]
        [StringLength(50)]
        [Display(Name = "Correo Electronico")]
        public String correo_electronico { get; set; }

        
        [Required(ErrorMessage = "Escriba el codigo del distrito")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "Codigo Distrito")]
        public string cliente_codigo_distrito { get; set; }

        [ForeignKey("cliente_codigo_distrito")]
        public Distrito distrito { get; set; }

    }
}
