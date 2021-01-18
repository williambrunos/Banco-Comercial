# Banco Comercial
 Um sistema de um Banco Comercial feito com C#.
 

 **SOBRE O PROJETO:**

 Este sistema visa resolver problemas de cadastros de clientes e suas respectivas contas bancárias, além de ser possível depositar e sacar dinheiro de cada conta. Além disso, foi feito para teste da arquitetura MVC(Model View Controller), que consiste em uma arquitetura de camadas, sendo estas: 

 *User Interface (Interface de Usuário): camada responsável por apresentar informações ao usuário e interpretar comandos do usuário;

 *Application Layer (Camada de Aplicação): camada responsável por coordenar as operações da aplicação, sem possuir regras de negócio;

 *Domain Layer (Camada de Domínio): camada responsável por saber informações sobre o negócio, ou seja, o domínio do problema, considerada o coração do software com suas regras de negócio;

 *Infrastructure Layer (Camada de Infraestrutura): é uma camada que dá suporte para as outras camadas, provendo a comunicação entre as camadas e implementando a persistência dos objetos de negócio no banco de dados, dentre outras funções.


 No sistema criado, não foram dadas as devidas atenções ao ApplicationLayer nem ao InfrastructureLayer, mas sim apenas ao UserInterface e ao DomainLayer. Portanto, concentre-se nesses dois por enquanto, depois vá aprimorando o sistema como desejar. 

 **COMO IMPLEMENTAR:**

 Dentro do Visual Studio, crie uma nova solução em branco(blank solution) para .NET FRAMEWORK. Após isso, crie 3 projetos de classes para .NET FRAMEWORK, sendo estes o projeto ApplicationLayer, InfrastructureLayer e DomainLayer, além de criar um projeto do tipo Console(ou o que desejar para fazer uma conexão do sistema com o usuário) .NETFRAMEWORK. 
 Após isso, implemente as classes .cs como mostradas nos arquivos da solução em seus respectivos projetos.Todo o código está comentado para facilitar o entendimento do mesmo :)

 **IMPORTANTE:**
 
  Não apenas copie o código apresentado, mas também realize a conexão entre os projetos DomainLayer e UserInterface. Para isso, abra o projeto UserInterface no Visual Studio, clique em "references" ou "referências", clique com o botão direito e em seguida "add reference" ou "adicionar referência". Em seguida, clique em "projetos" e escolha o projeto no qual deseja realizar a conexão, por exemplo: estamos no projeto UserInterface, portanto selecionamos o projeto DomainLayer para realizar a conexão. Por último(sim, acredite), em sua classe principal que conterá o método main no projeto UserInterface adicione 
 "using DomainLayer" para terminar de realizar a conexão entre os projetos.
