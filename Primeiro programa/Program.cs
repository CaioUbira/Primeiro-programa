// Screen Sound 

//camelcase A primeira palavra começa com letra minúscula e as próximas começam com maiúscula.
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "Rolling Stones", "Charlie Brown Jr" };
//PascalCase todas as palavras começam com letra maiúscula, inclusive a primeira.
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 7 });
bandasRegistradas.Add("ADC", new List<int>());
void ExibirLogo()
{// Verbatim Litera É especialmente útil para caminhos de arquivos, textos com muitas \ e strings multilinha.
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpçoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registarr uma banda ");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair ");
    Console.Write("\nDigite a sua opção: ");
    
    /* Esse ! é o operador de supressão de nulo (null-forgiving operator). 
     * O Console.ReadLine() pode retornar null, e o C# avisa sobre isso dependendo das configurações de nullable reference types.
     * O !está dizendo ao compilador:"Eu sei que esse valor pode ser nulo, mas neste caso pode confiar que não será." */
    string opcaoEscolhida = Console.ReadLine()!;

    //  "Parse" serve para converter o texto (string) que o usuário digitou em um número inteiro
    if (!int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
    {
        Console.Clear();
        ExibirOpçoesDoMenu();
        return;
    }
    /* SWITCH
     O switch é usado para verificar o valor de uma variável
     e executar um bloco de código de acordo com esse valor.
     Ele é uma alternativa ao uso de vários if e else if.*/
    switch (opcaoEscolhidaNumerica)
    /*CASE
     O case representa uma possível opção dentro do switch.
     Quando o valor da variável for igual ao valor do case,
     o código daquele case será executado.*/

    /*BREAK
     O break encerra a execução do case atual e sai do switch.
     Sem o break, o programa pode continuar a execução
     de outros casos, dependendo da forma como o switch foi escrito.*/
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3: 
            AvaliarUmaBanda(); 
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine(" Opção invalida");
            break;
    }
}
void RegistrarBanda()

{
    Console.Clear();
    ExibirTituloDaopcao("Registro de banda");
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    if (!bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} já está cadastrada!");
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaopcao("Exibindo todas as bandas registradas");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    // O $ antes de uma string permite colocar variáveis dentro do texto usando {}.
    //As chaves {} podem ter funções diferentes dependendo de onde aparecem. com $ significa:"Coloque aqui o valor de nome."
    // Os colchetes [] aparecem principalmente quando trabalhamos com listas, arrays e posições/índices.
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }


    Console.WriteLine("\ndigite uma tecla para voltar o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}
void ExibirTituloDaopcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos );
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");
}
void AvaliarUmaBanda()
{
    // Digite qual banda deseja avaliar 
    // se aa banda existir no dicionario >> atribuir uma nota 
    // se nao volta ao menu principal 

    Console.Clear();
    ExibirTituloDaopcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda{nomeDaBanda} merece: ");
        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        }
        else
        {
            Console.WriteLine("Digite uma nota válida!");
        }
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucessp para a banda{nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpçoesDoMenu();
    }
    
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
    }
}


ExibirOpçoesDoMenu();
