using System;
namespace exercicio_06
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;
    }
    public Produto()
    {
    }
    public Produto(string nome, string cor)
    {
        this.nome = nome;
        this.cor = cor;
    }

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando a classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando a classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando a classe produto");
        }

        protected void alteraAtributosPrivados(double peso2, double preco)
        {
            this.peso = peso2;
            this.preco = preco;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        }
	}
}