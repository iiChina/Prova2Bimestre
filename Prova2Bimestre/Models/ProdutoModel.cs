using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2Bimestre.Models
{
    public class ProdutoModel
    {
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public FornecedorModel Fornecedor { get; set; }
    }
}