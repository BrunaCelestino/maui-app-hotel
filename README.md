# MauiAppHotel

Projeto desenvolvido em **.NET MAUI** como atividade prática para criação de interfaces mobile.

## Objetivo da atividade

A proposta foi:

- Desenvolver o layout apresentado no material da disciplina;
- Personalizar o layout com identidade visual própria;
- Criar uma nova tela chamada **Sobre**;
- Adicionar informações do desenvolvedor, como nome e ano de desenvolvimento;
- Disponibilizar o projeto no GitHub junto das capturas de tela.

## Personalizações realizadas

Durante o desenvolvimento, foram realizadas melhorias visuais e funcionais:

- Personalização de cores utilizando `Colors.xaml`;
- Uso de fonte customizada `BebasNeue`;
- Reformulação completa do layout para visual mais moderno;
- Padronização visual entre todas as telas;
- Criação da tela **Sobre o Desenvolvedor**;
- Adição de foto do desenvolvedor em formato circular;
- Inclusão de informações como nome, ano de desenvolvimento, tecnologia e contato;
- Implementação de validações antes da confirmação da hospedagem.

## Validações implementadas

Foram adicionadas validações para melhorar a experiência do usuário e evitar falhas na aplicação:

- Exibição de mensagem caso nenhuma quantidade de hóspedes seja selecionada;
- Exibição de mensagem caso nenhuma suíte seja escolhida;
- Bloqueio do avanço enquanto informações obrigatórias não forem preenchidas;
- Prevenção de erros de execução, como `NullPointerException` ao tentar acessar dados não selecionados.

## Funcionalidades

O aplicativo permite:

- Selecionar quantidade de adultos e crianças;
- Escolher suíte;
- Selecionar período de hospedagem;
- Calcular valor total da diária;
- Visualizar confirmação da reserva;
- Acessar tela de informações do desenvolvedor.

## Capturas de tela

### Tela inicial - cálculo da diária
![Cálculo da diária](funcionamento/calculo-diaria.png)

### Validação de hóspede selecionado
![Validação hóspede](funcionamento/validacao-hospede-selecionado.png)

### Validação de quarto selecionado
![Validação quarto](funcionamento/validacao-quarto-selecionado.png)

### Reserva confirmada
![Reserva confirmada](funcionamento/reserva-confirmada.png)

### Tela Sobre
![Tela Sobre](funcionamento/sobre.png)

## Tecnologias utilizadas

- .NET MAUI
- C#
- XAML

## Desenvolvedora

**Bruna Celestino**  
Engenheira de Software Java  
Ano de desenvolvimento: **2026**