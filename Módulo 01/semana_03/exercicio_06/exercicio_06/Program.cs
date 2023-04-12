using System;

namespace exercicio_06
{
            Produto produto = new Produto();
            produto.nome = "Calculadora";
            produto.verificarEstoque();
            Console.WriteLine("O nome do produto é: " + produto.nome);

            ProdutoFinanceiro produtoFinanceiro = new ProdutoFinanceiro();

            produtoFinanceiro.nome = "Lapis";
            produtoFinanceiro.verificarEstoque();
            produtoFinanceiro.acesso();
}