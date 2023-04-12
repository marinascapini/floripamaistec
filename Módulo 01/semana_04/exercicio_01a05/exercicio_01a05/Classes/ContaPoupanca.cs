using System;
namespace exercicio_01a05.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        // exercício 03
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // exceção de novo, ver na próxima aula
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // exercício 06
        public override void Sacar(decimal valor)
        {
            valor += 0.10M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}