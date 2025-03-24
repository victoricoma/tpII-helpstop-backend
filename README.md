
# HelpApp

O **HelpApp** é um sistema destinado à gestão de atendimentos coluntários, facilitando a conexão entre individuas que necessitam de ajuda e voluntários disposto a oferecer suporte. Esta repositório contém backend do projeto, desenvolvido comuma arquitetura limpa e princípios sólidos de engenharia de software.

## Descrição Geral

O **HelpApp** permite o cadastro de usuários em dois perfis: ajudantes e solicitantes. A plataforma possibilita o registro e gerenciamento de atendimento, oferecendo uma agenda personalizada e histórico de ações. O Sistema foi desenvilvido utilizando a plataforma .NET core, com persistencia de dados em SQL Serve e implantação na nuvem via Azure App Services. Toda lógica foi projetada com base nos princípios SOLID, Visando um código sustentável e de facil manutenção. 

## Funcionalidades

*  Cadastro de usuários (ajudante e solicitante).
*  Registro e gerenciamento de atendimentos.
*  Agenda personalizada.
*  Histórico e relatórios de ações.
*  Login seguro com autenticação e autorização.

## Arquitetura do Projeto

O Projeto é estruturado em camadas , seguindo os padrões de Domain-Drivem Desing (DDD) e Clean Architecture:

*  **Domain:** Contém as entidades e interfazes que definem o nucleo do negócio.
*  **Application:** Implementa os casos de uso e a lógica de aplicação.
*  **Infrastrutue:** Resposável pela comunicação com o banco de dados e serviçõs externos.
*  **interfaces:** Inclui os controladores e interfaces de usuário.
  
## Princípios SOLID Aplicados

1. **Single Responsibility Principle:** Cada classe possui uma única responsabilidade. Por exemplo, a classe UserManager lida Exclusivamente com a logica de criação e atualização de usuários.

2. **Open/Closed Principle:** O sistema está aberto para extensão, mas fechado para modificação. Utilizamos interfaces com IUserRepository e IAttendanceService para permitir novas implementções sem alterar o código existente.
   
3. **Liskov Substituion Principle:** Subclasses podem substituir superclasses sem alterar o comportamento do sistema . Serviços de notificação como EmailNotifier e SmsNotifier herdam uma interdace comum e podem ser alternados sem quebrar funcionalidades.
   
4. **Interface Segragation Principle:** Interfaces especificas são preferíveis a genéricas. O HelpApp utiliza interfaces distintas para contextos deferentes, como IloginService A IAgendaMenager, evitando que uma classe implementa métodos que náo utiliza.
   
5. **Dependency Inversion Principle:** Módulos de alto nível não dependem de módulos de baixo nível: ambos dependem de abstrações.A camada de aplicação depende de interfaces, não diretamente de SQL Serve ou do .NET, tornado o código desacoplado e testável.
   
## Tecnologia e Ferramentas 
<table>
  <tr>
    <td>Linguagem</td>
    <td>Banco de Dados</td>
    <td>Amviente</td>
    <td>IDE</td>
    <td>ORM</td>
    <td>Testes</td>
    <td>Controle de Versão</td>
  </tr>
  <tr>
    <td>C# (.NET Core)</td>
    <td>SQL Serve</td>
    <td>Azure App Services</td>
    <td>Visual Studi / VS Code</td>
    <td>Entity Framework Core</td>
    <td>xUnit ou NUnit</td>
    <td>Git + GitHub</td>
  </tr>
</table>

## Como Rodar o Projeto

1. Clone o repositótio:
2. Abra o projeto no Visual Studio.
3. Configure a string de conexão no arquivo aapsettings.json.
4. Execute o comando Update-Database np Package Manager Console para aplicar as migratons.
5. Inicie a aplicação (pressione F5 ou utiliza a CLI).
6. Teste as rotas utilizando ferramentas como Postman ou Swagger.
  
## Testes Automatizados

O projeto inclui testes automatizados para as principais camadas, garantindo a qualidade e integridade do código. Para executar os testes:

1. Navegue até o diretório dos testes.

2. Execute os testes utilizando o comando apropriado para a ferramenta de testes escolhida (xUnit ou NUnit).

## Estrutura de Pastas 

1. HelpStop
    1. Domain/
       1. Interfaces/
    2. Application/
       1. UseCases/
    3. Infrastructura/
       1. Data/
          1. Services/
    4. Interfaces/
       1. Controllers/
    5. Tests/
    6. Progama.cs
       
## Autores

**Pedro Henrique Albuquerque Souza** 
**Função:** Desenvovedor Banck-end.
**Git:** Pedro4Albuquerque .

## Licença
Esta projeto eatá licenciado sob licença MIT.
