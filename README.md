# 🎵 Screen Sound

Aplicação de console desenvolvida em **C#** durante meus estudos de programação e desenvolvimento com **.NET**.

O projeto simula um sistema simples de cadastro e avaliação de bandas, permitindo registrar bandas, visualizar bandas cadastradas, adicionar avaliações e consultar a média das notas.

O objetivo principal foi colocar em prática conceitos fundamentais da linguagem **C#**, trabalhando com estruturas de dados, funções, condicionais, repetição e entrada de dados pelo usuário.

---

## 🚀 Funcionalidades

* 🎸 **Cadastrar bandas**
* 📋 **Exibir bandas cadastradas**
* ⭐ **Avaliar bandas**
* 📊 **Consultar a média das avaliações**
* 🔎 **Verificar se uma banda está cadastrada**
* ⚠️ **Validar entradas numéricas do usuário**
* 🖥️ **Interface interativa pelo terminal**

---

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET 8**
* **Visual Studio**
* **Git**
* **GitHub**

---

## 📚 Conceitos praticados

Durante o desenvolvimento do projeto, foram aplicados diversos conceitos fundamentais de C#:

* Variáveis
* Tipos `string` e `int`
* `if / else`
* `switch / case`
* `foreach`
* Métodos e funções
* Parâmetros
* `return`
* `List<T>`
* `Dictionary<TKey, TValue>`
* `ContainsKey()`
* `Add()`
* `TryParse()`
* `Average()`
* Interpolação de strings com `$`
* Índices com `[]`
* `Console.ReadLine()`
* `Console.WriteLine()`
* `Console.Clear()`
* `Console.ReadKey()`
* `Thread.Sleep()`
* Tratamento de entradas inválidas

---

## 🧠 Estrutura dos dados

O projeto utiliza um `Dictionary` para armazenar as bandas e suas respectivas avaliações:

```csharp
Dictionary<string, List<int>> bandasRegistradas
```

A estrutura funciona da seguinte forma:

```text
Banda → Lista de notas

Linkin Park → 10, 8, 7
ADC         → sem avaliações
```

A média da banda é calculada utilizando as notas armazenadas na lista:

```csharp
notasDaBanda.Average()
```

---

## 🎮 Menu da aplicação

Ao executar o programa, o usuário encontra as seguintes opções:

```text
1 - Registrar uma banda
2 - Mostrar todas as bandas
3 - Avaliar uma banda
4 - Exibir a média de uma banda
5 - Sair
```

---

## 💻 Exemplo de utilização

### Cadastro

```text
Digite o nome da banda que deseja registrar

A banda Charlie Brown Jr foi registrada com sucesso
```

### Avaliação

```text
Qual a nota que a banda Charlie Brown Jr merece:

A nota 9 foi registrada com sucesso
```

### Média

```text
Digite o nome da banda que deseja exibir a média:

A média da banda Charlie Brown Jr é 9
```

---

## 🎯 Objetivo do projeto

Este projeto faz parte da minha jornada de aprendizado em **desenvolvimento de software**, com foco na construção de uma base sólida em **C# e .NET**.

Além de praticar a sintaxe da linguagem, o projeto também me ajudou a compreender melhor a organização do código, manipulação de dados e criação de aplicações interativas em console.

---

## 📈 Próximos passos

Pretendo evoluir o projeto gradualmente, adicionando novos conceitos e funcionalidades conforme avanço nos estudos, como:

* 🔄 Melhor organização da estrutura do projeto
* 🧩 Separação de responsabilidades
* 💾 Persistência de dados
* 🗄️ Integração com banco de dados
* 🌐 Transformação em uma aplicação web
* 🧪 Testes automatizados
* 🏗️ Aplicação de conceitos de orientação a objetos

---

## 👨‍💻 Autor

**Caio Ubirajara Marques**

🎓 Análise e Desenvolvimento de Sistemas
💻 Em transição para a área de Tecnologia
🚀 Estudando C# / .NET e desenvolvimento de software

---

⭐ Este projeto foi desenvolvido como parte da minha evolução nos estudos de programação.
