using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Lançamentos.Data.Entities
{
    public class Lancamento
    {
        #region Properties
        public Guid IdLancamento { get; set; }        
        public string Descricao { get; set; }         
        public DateTime Data { get; set; }         
        public decimal Valor { get; set; }
        public bool Avulso { get; set; }
        public string Status { get; set; } // "Válido" ou "Cancelado"

        #endregion

        public  Lancamento()
        {
                Avulso = false;
        }
    }
}
