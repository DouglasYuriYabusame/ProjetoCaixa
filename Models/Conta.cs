using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Models
{
    [Table("conta")]
    public class Conta
    {
        [Key]
        [Column("codconta")]
        public int CodConta { get; set; }
        [Column("codcliente")]
        public int CodCliente { get; set; }
        [Column("saldoinicial")]
        public Decimal SaldoInicial { get; set; }
    }
}
