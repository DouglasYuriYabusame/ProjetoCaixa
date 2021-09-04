using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Models
{
    [Table("lancamento")]
    public class Lancamento
    {
        [Key]
        [Column("codlancamento")]
        public int CodLancamento { get; set; }       
        [Column("codconta")]
        public int CodConta { get; set; }
        [Column("valor")]
        public decimal Valor { get; set; }
        [Column("creditodebito")]
        public bool CreditoDebito { get; set; }
    }
}
