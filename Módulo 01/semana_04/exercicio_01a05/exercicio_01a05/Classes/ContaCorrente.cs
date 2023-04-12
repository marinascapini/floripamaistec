using System;
namespace exercicio_01a05.Classes
{
    public class ContaCorrente : ContaBancaria // classe filha - classe mae/superclasse
    {
        // exercício 03
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // exceção, semana 5
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa por saque
            valor += 0.50M;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa por transfer
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}