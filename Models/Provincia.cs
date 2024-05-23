using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_provincia")]
    public class Provincia
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo de la provincia")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "Codigo Provincia")]
        public String codigo_provincia { get; set; }

        [Required(ErrorMessage = "Escriba nombre de la provincia")]
        [StringLength(25)]
        [Display(Name = "Provincia")]
        public String provincia { get; set; }

        [Required(ErrorMessage = "Escriba el codigo del departamento")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "Codigo Departamento")]
        public string provincia_codigo_departamento { get; set; }

        [ForeignKey("provincia_codigo_departamento")]
        public Departamento departamento { get; set; }
    }
}
