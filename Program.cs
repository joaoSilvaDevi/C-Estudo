float listaGastos = 0;
float listaRecebimentos = 0;
int valorSleep = 1500;

void ExibirLogo(){

  Console.WriteLine(@"
  
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝

███████╗██╗███╗░░██╗░█████╗░███╗░░██╗░█████╗░███████╗██╗██████╗░░█████╗░
██╔════╝██║████╗░██║██╔══██╗████╗░██║██╔══██╗██╔════╝██║██╔══██╗██╔══██╗
█████╗░░██║██╔██╗██║███████║██╔██╗██║██║░░╚═╝█████╗░░██║██████╔╝██║░░██║
██╔══╝░░██║██║╚████║██╔══██║██║╚████║██║░░██╗██╔══╝░░██║██╔══██╗██║░░██║
██║░░░░░██║██║░╚███║██║░░██║██║░╚███║╚█████╔╝███████╗██║██║░░██║╚█████╔╝
╚═╝░░░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚══════╝╚═╝╚═╝░░╚═╝░╚════╝░
  ");

}

void ExebirOpcoesDoMenu(){
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma despesa.");
  Console.WriteLine("Digite 2 para registrar um recebimento.");
  Console.WriteLine("Digite 3 para mostrar o saldo atual.");
  Console.WriteLine("Digite 0 para sair.");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica){
    case 1: RegistrarDespesa();
      break;
    case 2: RegistrarRecebimento();
      break;
    case 3: MostrarSaldo();
      break;
    case 0:Console.WriteLine("Encerrando!");
      break;
    default: Console.WriteLine("Você selecionou uma opção invalida!");
      break;    
    }
}

void RegistrarDespesa(){
  Console.Clear();
  Console.WriteLine("Registro de Despesa!");
  Console.Write("Digite o valor da despesa: ");
  string valorDespesa = Console.ReadLine()!;
  float valorDespesaInteiro = float.Parse(valorDespesa);
  listaGastos += valorDespesaInteiro;
  Console.WriteLine($"A despesa no valor de R${valorDespesaInteiro} com sucesso!");
  Thread.Sleep(valorSleep);
  Console.Clear();
  ExebirOpcoesDoMenu();
}

void RegistrarRecebimento(){
  Console.Clear();
  Console.WriteLine("Registro de Recebimento!");
  Console.Write("Digite o valor recebido: ");
  string valorRecebimento = Console.ReadLine()!;
  float valorRecebimentoInteiro = float.Parse(valorRecebimento);
  listaRecebimentos += valorRecebimentoInteiro;
  Console.WriteLine($"O recebimento no valor de R${valorRecebimentoInteiro} com sucesso!");
  Thread.Sleep(valorSleep);
  Console.Clear();
  ExebirOpcoesDoMenu();
}

void MostrarSaldo(){
  Console.Clear();
  Console.WriteLine("Registro de Recebimento!");
  float saldoAtual = listaRecebimentos - listaGastos;
  Console.WriteLine($"Atualmente o saldo está no valor de R${saldoAtual}!");
  Thread.Sleep(valorSleep);
  Console.Clear();
  ExebirOpcoesDoMenu();
}


ExebirOpcoesDoMenu();