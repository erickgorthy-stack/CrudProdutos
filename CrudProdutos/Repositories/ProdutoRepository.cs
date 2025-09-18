using CrudProdutos.Entities;
using CrudProdutos.Settings;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Repositories
{
    public class ProdutoRepository
    {
         public void Inserir(Produto produto)
        {
            var query = """
                INSERT INTO PRODUTO(ID, NOME, PRECO, QUANTIDADE, DATAHORACADASTRO, DATAHORAULTIMAALTERACAO)
                VALUES(@Id, @Nome, @Preco, @Quantidade, @DataHoraCadastro, @DataHoraUltimaAlteracao)
                """;
            using (var connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Execute(query, produto);
            }

        }
        public void Atualizar(ProdutoRepository produto)
        {

        }
        public void Excluir(Guid id)
        {

        }
        public List<Produto> Consultar()
        {
            return null;
        }
    }
}
