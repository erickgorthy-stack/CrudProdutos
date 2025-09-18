using CrudProdutos.Entities;
using CrudProdutos.Repositories;
using CrudProdutos.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Controllers
{
    public class ProdutoController
    {
        public void CadastrarProduto()
        {
            var produto = new Produto();

            Console.Write("NOME DO PRODUTO..:");
            produto.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("PREÇO DO PRODUTO..:");
            produto.Preco = decimal.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.Write("QUANTIDADE..:");
            produto.Quantidade = int.Parse(Console.ReadLine() ?? string.Empty);

            //Validar os dados do produto
            var produtoValidator = new ProdutoValidator();
            var result = produtoValidator.Validate(produto);

            if (result.IsValid)
            {
                var produtoRepository = new ProdutoRepository();
                produtoRepository.Inserir(produto);

                Console.WriteLine("\n PRODUTO CADASTRADO COM SUCESSO!");
            }
            else
            {
                Console.WriteLine("\nOCORRERAM ERROS DE VALIDAÇÃO:");
                foreach (var item in result.Errors)
                {
                    Console.WriteLine($"\tERRO: {item.ErrorMessage}");
                }
            }
        }
    }
}
