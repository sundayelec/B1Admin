using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1
{
    [Table("clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        public required string Nombre { get; set; }

        public required string Apellido { get; set; }

        public required string Email { get; set; }

        public required string Telefono { get; set; }
    }
}
