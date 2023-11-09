using System.ComponentModel.DataAnnotations;

namespace API_Lançamento.Services.Models
{
    public class LancamentosPutModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public Guid IdLancamento { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public bool Avulso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Status { get; set; }
    }
}
