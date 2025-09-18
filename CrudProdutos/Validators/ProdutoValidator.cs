using CrudProdutos.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            //Validação do campo 'Nome'
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do produto.")
                .Length(8, 100).WithMessage("Por favor, informe o nome do produto de 8 a 100 caracteres.");

            //Validação do campo 'Preco'
            RuleFor(p => p.Preco)
                .NotNull().WithMessage("Por favor, informe o preço do produto.")
                .GreaterThan(0).WithMessage("Por favor, informe o preço com valor maior do que zero.")
                .LessThanOrEqualTo(100000).WithMessage("Por favor informe o preço com valor até 100000.");

            //Validação do campo 'Quantidade'
            RuleFor(p => p.Quantidade)
                .NotNull().WithMessage("Por favor, informe a quantidade do produto")
                .GreaterThanOrEqualTo(1).WithMessage("Por favor, informe a quantidade com valor maior ou igual a 1.")
                .LessThanOrEqualTo(1000).WithMessage("Por favor informe a quantidade com valor até 1000.");
        }
    }
}
