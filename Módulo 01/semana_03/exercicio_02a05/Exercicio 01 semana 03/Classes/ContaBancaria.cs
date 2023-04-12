using System;
using Exercicio_01_semana_03.Classes.Enum;

public class ContaBancaria // exercicio 03 - alteração de visibilidade da classe 
{
        // exercício 04
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // exercício 03
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {

        // atribuir os valores do construtor ( _ pois é private) - exercicio 01
        _numero = numero;
        _agencia = agencia;
        _nomeDoTitular = nomeDoTitular;
        _tipoConta = tipoConta;
        }

        // exercício 05
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // Instancia uma classe Random para gerar número aleatórios
            Random random = new Random();

            // gera um número aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            // atribui os valores do construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        public void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            _saldo = _saldo - valor;
            //_saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }


        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }


        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }


        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }

    internal void Depositar(int v)
    {
        throw new NotImplementedException();
    }
}