# Calculadora de Descontos - xUnit

Este projeto foi desenvolvido como parte da lista de exercícios da disciplina de **Gestão e Qualidade de Software**. O objetivo principal é implementar regras de negócio e testá-las utilizando testes unitários parametrizados.

## 🧪 Entendendo o xUnit: [Fact] vs [Theory]

Uma das exigências desta atividade é a compreensão prática sobre a diferença entre as duas abordagens de testes no framework xUnit:

*   **`[Fact]` (Fato):** É utilizado para testar um cenário único e estático. O método de teste não recebe parâmetros (argumentos). Os valores a serem testados são definidos e fixados dentro do próprio corpo do teste.
*   **`[Theory]` (Teoria):** É utilizado para executar o **mesmo teste várias vezes com dados diferentes**. O método de teste recebe parâmetros, e os dados de entrada e saída esperada são injetados através do atributo `[InlineData(dados...)]`. Isso evita a duplicação de código e garante que uma mesma regra funcione para vários cenários.

## ⚙️ Regras de Negócio Implementadas

A classe `DescontoService.cs` contém os seguintes métodos, todos validados via `[Theory]`:

1.  **`ObterCategoriaCliente(int totalCompras)`:**
    *   Retorna `BRONZE` para menos de 5 compras.
    *   Retorna `PRATA` para compras entre 5 e 10 (inclusive).
    *   Retorna `OURO` para mais de 10 compras.
2.  **`CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)`:**
    *   Calcula e retorna o valor final da compra após a aplicação do desconto percentual.
3.  **`EValidoParaCupom(int idade, bool primeiraCompra)`:**
    *   Retorna `true` se o cliente possuir 18 anos ou mais, **ou** se for a sua primeira compra.

## 🚀 Como Executar os Testes

Para rodar a suíte de testes parametrizados e validar todos os cenários construídos com `[InlineData]`, siga os passos abaixo:

1. Abra o terminal na raiz da solução ou dentro da pasta do projeto de testes.
2. Execute o comando nativo do .NET:
   ```bash
   dotnet test
3. O console exibirá a execução individual de cada cenário parametrizado, confirmando o sucesso da suíte.

Desenvolvido por: Maria Luísa do Carmo Cardoso
RA: 325116932
