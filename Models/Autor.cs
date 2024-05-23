using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo del Autor")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "ID Autor")]
        public String id_autor { get; set; }

        [Required(ErrorMessage = "Escriba nombre del Autor")]
        [StringLength(50)]
        [Display(Name = "Nombre Autor")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Escriba apellido del Autor")]
        [StringLength(50)]
        [Display(Name = "Apellido Autor")]
        public String apellido { get; set; }

        [Required(ErrorMessage = "Escriba la nacionalidad del Autor")]
        [StringLength(50)]
        [Display(Name = "Nacionalidad Autor")]
        public String nacionalidad { get; set; }
    }
}
