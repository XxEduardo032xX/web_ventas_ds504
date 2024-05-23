using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo de la categoría")]
        [MinLength(5, ErrorMessage = "Escriba 5 Caracteres")]
        [Display(Name = "ID Categoria")]
        public String id_categoria { get; set; }

        [Required(ErrorMessage = "Escriba el nombre de la Categoria")]
        [StringLength(50)]
        [Display(Name = "Nombre de la Catergia")]
        public String nombre_categoria { get; set; }
    }
}
