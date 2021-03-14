using System;
using System.Collections.Generic;
using System.Text;

namespace PrDDD.Domain.Entities
{
    public class LoteArquivo : BaseEntity
    {
        public List<Produto> Produtos { get; set; }
        public DateTime DataImportacao { get; set; }
    }
}
