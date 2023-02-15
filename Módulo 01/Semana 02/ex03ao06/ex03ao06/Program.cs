using ex03ao06;

ContaBancaria conta = new ContaBancaria();
conta.numero = 1234;
conta.agencia = 1689;
conta.nomeDoTitular = "Capivara";
conta.tipoConta = TipoContaEnum.POUPANCA;

// depositar
conta.Depositar(500);

// sacar 
conta.Sacar(150);

// exibir saldo
conta.ExibirSaldo();