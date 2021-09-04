using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetocaixa.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Column("codcliente")]
        public int CodCliente { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
        [Column("email")]
        public String Email { get; set; }
        [Column("celular")]
        public String Celular { get; set; }
    }  
}
