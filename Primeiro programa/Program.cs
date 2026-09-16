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
    switch (opcaoEscolhidaNumerica)

    /* SWITCH
     O switch é usado para verificar o valor de uma variável
     e executar um bloco de código de acordo com esse valor.
     Ele é uma alternativa ao uso de vários if e else if.*/

    /*CASE
     O case representa uma possível opção dentro do switch.
     Quando o valor da variável for igual ao valor do case,
     o código daquele case será executado.*/

    /*BREAK
     O break encerra a execução do case atual e sai do switch.
     Sem o break, o programa pode continuar a execução
     de outros casos, dependendo da forma como o switch foi escrito.*/
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine(" Opção invalida");
            break;
    }
}
ExibirMesagemDeBoasVindas();
ExibirOpçoesDoMeni();
