![logo HelpApp](https://github.com/user-attachments/assets/75f7bd61-e719-4f2b-994a-3cc8f563ff83)

# 🔎 HelpStop
Um aplicativo de gestão de atendimentos com arquitetura limpa e princípios sólidos de engenharia de software.

## 📚 Descrição Geral:
O HelpApp é um sistema de aprendizagem desenvolvido nas aulas de Técnicas de Programação II, do curso de Desenvolvimento de Software Multiplataforma, pela Fatec Matão - Luiz Marchesan. O projeto foi desenvolvido utilizando a plataforma .NET CORE, com persistência em SQL Server e implementação na nuvem via Google Firebase. Toda a lógica doi projetada com base nos princípios de desenvolvimeto sustentável e manutenção facilitada, utilizando os conceitos do **SOLID**.

## 🧩 Tecnologias
- **Linguagem:** C# (.NET core)
- **Banco de Dados:** SQL Server
- **ORM:** Entity Framework Core
- **IDE:** Visual Studio / VS Code
- **Testes:** xUnit ou NUnit
- **Controle de Versão:** Git + GitHub

## 🪜 Funcionalidades
 - Cadastro de usuários.
 - Agenda e gerenciamento de atendimentos.
 - Agenda personalizada.
 - Notificação por e-mail e SMS.
 - Login seguro com autenticação e autorização.

 ## 🏗️ Arquitetura de Projeto
 O HelppApp segue uma arquitetura baseada em **Clean Architecture**, dividida em camadas:
 - Domain: Contém todas as entidades principais do sistema.
 - Application: Implementa as regras de negócio e casos de uso.
 - Infrastructure: Responsável pelo acesso ao banco de dados e serviçoes externos.
 - Interfaces: Contém a interface gráfica para interação com os usuários.

## ⚙️ Princípios SOLID Aplicados
1. S - Single Responibility Principle
Cada classe possui uma responsabilidade únida. Exemplo: `UserManager` gerencia apenas usuários, sem interferir na autenticação.

2. O - Open/Closed Principle
O sistema é aberto para extensão, mas fechado para modificação. Exemplo: interfaces como `IAttendanceService` permitem adição de novas implementações sem alterar o código existente.

3. L - Liskov Substituion Principle
Classes derivadas devem substituir suas classes bases sem alterar o comportamento esperado. Exemplo: `EmailNotifier` e `SmsNotifier` implemetam uma interface comum.

4. I - Interface Segration Principle
Interfaces menores e mais específicas. Exemplo: `ILoginService` e `IAgendaManager` evitam que uma classe implemete métodos desnecessários.

5. D - Dependency Inversion Principle
Módulos de alto nível dependem de abstrações. Exemplo: a camada de aplicação interage com repostórios através de interfaces.

## 🔧 Como Rodar o Projeto
1. Clone o repósitorio: 
```bash
https://github.com/miguelmorandini/tpII-helpstop-backend.git
```

2. Abra o projeto no **Visual Studio**.

3. Configure a string de conexão no `appsetting.json`.

4. Abra a solução `HelpApp.sln`.

5. Execute as migrations através do código: 
```bash
Update-Database
```

6. Rode a aplicação:
```bash
dotnet run
```

7. Teste as rotas via **Postman** ou **Swagger**.

## 🧪 Teste Automatizados
- Teste nas camadas principais, `Application` e `Domain`.
- Execute os teste: 
```bash
dotnet test
```
- xUnit ou NUnit.
- Priorizam as Regras de Negócio.

## 📂 Estrutura de Pastas
```bash
HelpApp/
├── HelpApp.API/
    └── Controllers/
    └── Properties/
├── HelpApp.Application/
    └── Services/
├── HelpApp.Domain/
    └── Entities/
    └── Interfaces/
    └── Validation/
├── HelpApp.Domain.Test/
├── HelpApp.Infra.Data/
    └── Repositories/
├── HelpApp.Infra.IoC/
```

## 👨‍💻 Autor
Miguel Miranda Morandini - Back-end, Testes, Modelagem e Documentação -  ([@Miguel](https://github.com/miguelmorandini))

## 📜 Licença
Este projeto está sob `MIT License`. Confira o arquivo `LICENSE` neste repósitorio.

![banner HelpApp](https://github.com/user-attachments/assets/95b3f8d0-8df9-4409-9970-9a98b34f0d55)
