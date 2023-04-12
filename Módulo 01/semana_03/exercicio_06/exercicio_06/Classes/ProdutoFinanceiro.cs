using System;
namespace exercicio_06
{
	internal class ProdutoFinanceiro : Produto
	{
        public ProdutoFinanceiro()
        {

        }

        public ProdutoFinanceiro(string nome, string cor) : base(nome, cor)
        {

        }

        public void Acesso()
        {
            ProdutoFinanceiro produto = new ProdutoFinanceiro("Caneta", "Azul");
            produto.Vender();
            produto.AlterarAtributsPrivados(99, 100.0);
        }
	}
}