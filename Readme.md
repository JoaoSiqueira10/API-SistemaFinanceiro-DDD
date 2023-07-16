<h1 align="center"> Sistema Fincanceiro-DDD</h1>

<h2 align="left"> Descrição do Projeto </h2>

Criação do Sistema financeiro para gerenciamento de finanças.

<h2 align="left"> Ferramentas Utilizadas </h2>

- `Visual Studio 2022`: Para criação das APIs(Back-End) com C#. 
- `Visual Code`: Para criação do Front-End com Angular.
- `SQL Server`: Utilizado para criação de banco de dados.

<h2 align="left"> DDD (Domain Drive Design) </h2>

- Utiliza o DDD (Domain Drive Design) não é arquitetura em camadas e nem uma tecnologia.
- O conceito de DDD é uma abordagem de modelagem de software que segue um conjunto de práticas com objetivo de facilitar a implementação de complexas regras e processos de negócios que tratamos como domínio.

<h2 align="left"> Tecnologias Utilizadas </h2>

- Identity (Gerenciamento de usuários).
- Linq C# para as Querys.
- Generics.
- JWT (Json Web Token) / APIs Autenticadas.
- Dependency Injection (Singleton).
- CORS - Cross-Origin Resource Sharing (Compartilhamento de recursos com origens diferentes) é um mecanismo que usa cabeçalhos adicionais HTTP para imformar a um navegador que permita que um aplicativo Web seja executado em uma origem (domínio) com permissão para acessar recursos selecionados de um servidor em uma origem distinta. Um aplicativo Web executa uma requisição cross-origin HTTP ao solicitar um recurso que tenha uma origem diferente (domínio, protocolo e porta) da sua própria.

<h2 align="left"> Linguagens </h2>
<h3 align="left"> Back-End </h3>

- C#/CSharp.
- SQL.

<h3 align="left"> Front-End </h3>

- Angular.
- TypeScript.
- CSS.
- HTML.

<h2 align="left"> Detalhes Arquitetura</h2>
<h3 align="left"> Back-End </h3>

- `Dominio`: Serviços, validações e regras.
- `Infra`: Camada responsável por execução no banco de dados.
- `Helpers`: Camada de metódos de auxilio como os Singleton compartilhados.
- `WebAPIs`: Camada de hospedagem das APIs disponíveis para front-end.

<h3 align="left"> Front-End </h3>

- `Componentes`: Todos os Componentes comuns utilizados em telas.
- `Pages`: Todas as paginas do sistema com a estrutura de HTML, CSS e TypeScript.
- `Serviços`: Reponsáveis por chamadas de APIs.
- `Environments`: Reponsáveis por armazenagem dos Endpoint.

<h2 align="left"> Pacotes Utilizados </h2>

- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.AspNetCore.OpenApi
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Swashbuckle.AspNetCore

<h2 align="left"> Referencia </h2>

- Canal do Youtube: https://www.youtube.com/@devnetcore
