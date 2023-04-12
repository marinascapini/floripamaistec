using Exercicio_01_semana_03;
using Exercicio_01_semana_03.Classes.Enum;

ContaBancaria conta1 = new ContaBancaria(1828, 1234, "Doguinho", TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria(1848, 1234, "Capivara", TipoContaEnum.POUPANCA);

// depositar
conta1.Depositar(200);

conta1.Transferir(conta2, 0);

// exibe o saldo da conta1
conta1.ExibirSaldo();
// deve retornar que o saldo é 150

// exibe o saldo da conta1
conta2.ExibirSaldo();
// deve retornar que o saldo é 50