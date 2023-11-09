using System.ComponentModel.DataAnnotations;

namespace API_Lançamento.Services.Models
{
    public class LancamentosGetModel
    {
        
        public Guid IdLancamento { get; set; }
       
        public string Descricao { get; set; }
        
        public DateTime Data { get; set; }
       
        public decimal Valor { get; set; }
        
        public bool Avulso { get; set; }
        
        public string Status { get; set; }
    }
}
