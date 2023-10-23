using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsConDetalle.Shared;

public class Tickets
{
    [Key]
    public int TicketId {get; set;}

    [Required(ErrorMessage ="Debe de insertar una Fecha")]
    public DateTime Fecha {get; set;} = DateTime.Now;

    [Required(ErrorMessage ="El campo Solicitado Por es obligatorio")]
    [StringLength(35, ErrorMessage ="Ha insertado mas de {0} caracteres")]
    [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage ="El campo SolicitadoPor solo debe de contener caracteres alfabeticos")]
    public string SolicitadoPor {get; set;} = string.Empty;

    [Required(ErrorMessage ="El campo Asunto es obligatorio")]
    [StringLength(75, ErrorMessage ="Ha insertado mas de {0} caracteres")]
    public string Asunto {get; set;} = string.Empty;

    [Required(ErrorMessage ="El campo Descripcion es obligatorio")]
    [StringLength(75, ErrorMessage ="Ha insertado mas de {0} caracteres")]
    public string Descripcion {get; set;} = string.Empty;

    [ForeignKey("TicketId")]
    public ICollection<TicketsDetalle> TicketsDetalle {get; set;} = new List<TicketsDetalle>();
}