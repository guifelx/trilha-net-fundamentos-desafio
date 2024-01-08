using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
      static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne) {
        double transporte = quilometrosPorDia*365*0.2;
        double eletrônicos = horasDeEletronicos*0.1;
        double consumoCarne = refeicoesComCarne*0.5;
        
        double total = transporte + eletrônicos + consumoCarne; 
        
        return total; 
      }
}


















/*     static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        Console.WriteLine("Digite a quantidade de jogos");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
        string[]nomesJogos = new string[quantidadeJogos]; 

        // TODO: Crie um Loop para adicionar jogos conforme a quantidade especificada:
        for (int indice = 0; indice < quantidadeJogos; indice++) {
            Console.WriteLine($"Digite o nome do {indice}º jogo");
                AdicionarJogo(indice, nomesJogos);
        }     

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string nomesConcatenados = string.Join(", ", nomes);

        Console.WriteLine($"Foram adicionados '{quantidadeJogos}' jogos: {nomesConcatenados}");
        
    }


 */

/*     static void Main()
    {
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;
    
    // TODO: Crie um Loop para percorrer os números no intervalo
    for (int i = limiteInferior; i <= limiteSuperior; i++) {
      
      
    // TODO: Implemente o if para verificar se o número é par:  
    if (i % 2 ==0){
      somaPares += i; 
    }
    }

    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}"); */

/* // TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
  
    string descricao = Console.ReadLine();

    Console.WriteLine(descricao.Length);
    
    if (descricao.Length > 50) {
       Console.WriteLine("O valor da descrição excede a quantidade de caracteres permitidos");
    }
      else {
 // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
        string dataVencimento = Console.ReadLine();
 // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
        Console.WriteLine($"{descricao} até {dataVencimento}");
      }    
    }
} */
/* using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
 */