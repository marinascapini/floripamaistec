using System;
namespace ex03ao06
{
	public class ContaBancaria
	{
		// Exercício 03
		public int numero;
		public int agencia;
		public string nomeDoTitular;
		public decimal saldo = 0;
		public TipoContaEnum tipoConta;

		// Exercício 04
		public void Depositar(decimal valor)
		{
			if (valor <= 0) // conferir se valor é menor que 0, se sim:
			{
				Console.WriteLine("O valor precisará ser maior que zero");
			}
			else
			{
				saldo = saldo + valor; // para contar somar o valor antigo
			}
		}

		// Exercício 05
		public void Sacar(decimal valor)
		{
			if (valor <= 0)
			{
				Console.WriteLine("O valor precisa ser maior do que 0");
			}
			else if (valor > saldo)
			{
				Console.WriteLine("O valor é maior do que o saldo atual");
			}
			else
			{
				saldo = saldo - valor;
			}
		}

		// Exercício 06
		public void ExibirSaldo()
		{
			Console.WriteLine($"O saldo atual da conta é de R$ {saldo}"); // $: interpolação de string
		}
	}
}