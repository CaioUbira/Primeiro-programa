// Screen Sound 

//camelcase A primeira palavra começa com letra minúscula e as próximas começam com maiúscula.
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

//PascalCase todas as palavras começam com letra maiúscula, inclusive a primeira.
void ExibirMesagemDeBoasVindas()
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
void ExibirOpçoesDoMeni()
{
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
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine(" Voce escolhe a opção " + opcaoEscolhidaNumerica);
    }
    else if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine(" Voce escolhe a opção " + opcaoEscolhidaNumerica);
    }
}
ExibirMesagemDeBoasVindas();
ExibirOpçoesDoMeni();
