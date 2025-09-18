using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Entities
{
    public class Produto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;
        public DateTime DataHoraUltimaAlteracao { get; set; } = DateTime.Now;
    }
}
