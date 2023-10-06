
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessToCsv.Model
{
    public class Dados
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string? Dados1 { get; set; }

        [MaxLength(30)]
        public string? Dados2 { get; set; }

        [MaxLength(30)]
        public string? Dados3 { get; set; }

        [MaxLength(30)]
        public string? Dados4 { get; set; }

        [MaxLength(30)]
        public string? Dados5 { get; set; }

        [MaxLength(30)]
        public string? Dados6 { get; set; }

        [MaxLength(30)]
        public string? Dados7 { get; set; }

        [MaxLength(30)]
        public string? Dados8 { get; set; }

        [MaxLength(30)]
        public string? Dados9 { get; set; }

        [MaxLength(30)]
        public string? Dados10 { get; set; }
    }
}
