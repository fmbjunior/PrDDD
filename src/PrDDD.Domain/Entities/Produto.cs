using System;
using System.Collections.Generic;
using System.Text;

namespace PrDDD.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public DateTime DataEntrega { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
