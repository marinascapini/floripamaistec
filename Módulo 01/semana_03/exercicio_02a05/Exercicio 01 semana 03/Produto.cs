using System;
namespace Exercicio_01_semana_03
{
    // Exercicio 01 - criar classe produto public e construtor
	public class Produto
	{
		public string nome;
		public double preco;
		public int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public Produto()
        {
            nome = "Sem nome";
            preco = 0;
            quantidade = 0;
        }
    }
}