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
    case 2: Console.WriteLine("Você escolher a opção " + opcaoEscolhidaNumerica);
      break;
    case 3: Console.WriteLine("Você escolher a opção " + opcaoEscolhidaNumerica);
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
  Console.WriteLine($"A despesa no valor de R${valorDespesaInteiro} com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExebirOpcoesDoMenu();
}


ExebirOpcoesDoMenu();