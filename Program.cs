using bytebank;
using System.Runtime.CompilerServices;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André";
contaDoAndre.saldo = 1000.00;
contaDoAndre.numero_agencia = 0119;
contaDoAndre.conta_corrente = "47835-7";

Console.WriteLine("Foram solicitadas as informações de um cliente ao terminal, enviando-as.");



Console.WriteLine("Titular da conta: " + contaDoAndre.titular);
Console.WriteLine("Saldo disponivel na conta: " + contaDoAndre.saldo);
Console.WriteLine("Número da agencia: " + contaDoAndre.numero_agencia);
Console.WriteLine("Número da Conta Corrente: " + contaDoAndre.conta_corrente);

Console.WriteLine("======================");


contaDoAndre.Depositar(10000.00);
contaDoAndre.Depositar(5412.00);
contaDoAndre.Sacar(1000.00);

ContaCorrente contaDaEtnilda= new ContaCorrente();

contaDaEtnilda.titular = "Jéssica";
contaDaEtnilda.conta_corrente = "77777-51";
contaDaEtnilda.numero_agencia = 051;
contaDaEtnilda.saldo = 10000;

contaDoAndre.Transferir(1500.00, contaDaEtnilda);
