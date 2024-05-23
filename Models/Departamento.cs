using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_departamento")]
    public class Departamento
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo del departamento")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "Codigo Departamento")]
        public String codigo_departamento { get; set; }

        [Required(ErrorMessage = "Escriba nombre del departamento")]
        [StringLength(25)]
        [Display(Name = "Departamento")]
        public String departamento { get; set; }
    } 
}
