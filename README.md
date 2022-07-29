# Boas-vindas ao repositório do projeto TryBank

Para realizar o projeto, atente-se a cada passo descrito a seguir e, se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver </strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-trybank`.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-trybank`

  2. Instale as dependências

  - `dotnet restore`.
  
  1. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-project-trybank`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-project-trybank`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-trybank`/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-trybank`/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento </strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request </strong></summary><br />

  Use o conteúdo sobre [Code Review](https://course.betrybe.com/real-life-engineer/code-review/) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional, e que compartilhar o seu aprendizado lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe esse projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Boas-vindas ao TryBank, uma iniciativa de implementar um serviço de banco financeiro para sua instituição do coração.💚

Você recebeu a demanda de criar a versão inicial do TryBank, bem como seus testes. Nesse projeto, você tem como objetivo construir um banco que contenha contas. Além disso, deve criar e validar os processos de cadastro, login, saque, depósito e transferência do saldo dessas contas. 

De olho na dica👀: Faça uma boa separação de responsabilidades e crie testes estruturados, garantindo assim que a evolução desse sistema ocorra facilmente.
 

## 1 - O programa deve cadastrar novas contas
Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o cadastro de novas contas</summary><br />

Crie esse requisito na função `RegisterAccount()`

Se essa combinação de **número e agência** já existir, você deverá lançar uma exceção do tipo `ArgumentException` com a mensagem `A conta já está sendo usada!`.

Caso contrário, a função deve armazenar os dados no array `Bank` na próxima posição disponível marcada por `registeredAccounts`

Caso tudo corra bem, a função deve incrementar a variável registeredAccounts;

</details>

<details>
  <summary>Crie os testes para o cadastro de contas</summary><br />

Crie esse requisito em `src/trybank.Test/TestFirstReq.cs`

Em `TestRegisterAccountSucess`, crie a lógica para verificar se a função `RegisterAccount` cadastra os dados passados por parâmetro.

Em `TestRegisterAccountException`, crie a lógica para verificar se a função `RegisterAccount`retorna uma exceção quando é passada uma conta que já existe.
De olho na dica 👀: Confira o lançamento de exceção e a mensagem que é retornada na exceção
</details>

## 2 - A pessoa usuária deve conseguir fazer Login e Logout
Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir o Login da pessoa usuária</summary><br />

Crie esse requisito na função `Login()`

O estado de pessoa usuária logada é controlado pela variável `Logged`


- **Se já houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário já está logado`


 **Caso contrário**, a função deve procurar por essa combinação de número e agência.

-   **Se encontrado e a senha for correta**, a função deve alterar o estado da variável `Logged` e armazenar a posição da pessoa usuária logada na variável `loggedUser` (será útil futuramente para as próximas funções, fica a dica!)

-   **Se encontrado e a senha for incorreta**, você deve lançar uma exceção do tipo `ArgumentException` com a mensagem `Senha incorreta`

-   Se não for encontrada a combinação de `número e agência`, você deve lançar uma exceção do tipo `ArgumentException`com a mensagem `Agência + Conta não encontrada`


</details>

<details>
  <summary>O programa deve permitir o Logout do usário</summary><br />

Crie esse requisito na função `Logout()`

O estado de pessoa usuária logada é controlado pela variável `Logged`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário não está logado`

**Caso contrário**, a função deve alterar o estado da variável `Logged` e o índice de pessoa usuária `loggedUser` de volta para `-99`
</details>

<details>
  <summary>Crie os testes para o Login</summary><br />

Crie esse requisito em `src/trybank.Test/TestSecondReq.cs`

Em `TestLoginSucess`, crie a lógica para verificar se a função `Login` consegue alterar o estado da variável Logged.

Em `TestLoginExceptionLogged`, crie a lógica para verificar se a função `Login` retorna uma exceção quando é executada com uma conta já logada.

Em `TestLoginExceptionWrongPass`, crie a lógica para verificar se a função `Login` retorna uma exceção quando uma senha incorreta é passada.

Em `TestLoginExceptionNotFounded`, crie a lógica para verificar se a função `Login` retorna uma exceção quando uma combinação de número e agência não existe no array Bank.
</details>

<details>
  <summary>Crie os testes para o Logout</summary><br />

Crie esse requisito em `src/trybank.Test/TestSecondReq.cs`

Em `TestLogoutSucess`, crie a lógica para verificar se a função `Logout` consegue alterar o estado da variável Logged.

Em `TestLogoutExceptionNotLogged`, crie a lógica para verificar se a função `Logou` retorna uma exceção quando é executada sem uma conta já logada.

</details>

## 3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro
Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir verificar o saldo na conta da pessoa usária logada</summary><br />

Crie esse requisito na função `CheckBalance()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário já está logado`

**Caso contrário**, a função deve retornar o saldo na conta da pessoa usuária logada.
</details>

<details>
  <summary>O programa deve permitir o depósito de um valor na conta da pessoa usária logada</summary><br />

Crie esse requisito na função `Deposit()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException` com a mensagem `Usuário já está logado`

**Caso contrário**, a função deve adicionar o valor passado por parâmetro para o saldo da pessoa usuária logada.
</details>

<details>
  <summary>O programa deve permitir o saque de um valor na conta da pessoa usuária logada</summary><br />

Crie esse requisito na função `Withdraw()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tpo `AccessViolationException`, com a mensagem `Usuário já está logado`

**Caso contrário**, a função deve retirar o valor passado por parâmetro para o saldo da pessoa usuária logada.
  Se o saldo da conta da pessoa usuária logada for insuficiente para fazer o saque, você deve lançar uma exceção do tipo `InvalidOperationException` com a mensagem `Saldo insuficiente`
</details>

<details>
  <summary>Crie os testes para Checar o Saldo</summary><br />

Crie esse requisito em `src/trybank.Test/TestThirdReq.cs`

Em `TestCheckBalanceSucess`, crie a lógica para verificar se a função `CheckBalance` consegue retornar corretamente o saldo de uma conta já logada.
  De olho na dica👀: Insira uma conta diretamente no array Bank ou use a função Login que já foi testada 🤗

Em `TestCheckBalanceWithoutLogin`, crie a lógica para verificar se a função `CheckBalance` retorna uma exceção quando é executada sem uma conta logada.

</details>

<details>
  <summary>Crie os testes para o Deposito</summary><br />

Crie esse requisito em `src/trybank.Test/TestThirdReq.cs`

Em `TestDepositSucess`, crie a lógica para verificar se a função `Deposit` consegue alterar o saldo de uma conta já logada.  

Em `TestDepositWithoutLogin`, crie a lógica para verificar se a função `Deposit` retorna uma exceção quando é executada sem uma conta logada.

</details>

<details>
  <summary>Crie os testes para o Sacar</summary><br />

Crie esse requisito em `src/trybank.Test/TestThirdReq.cs`

Em `TestWithdrawSucess`, crie a lógica para verificar se a função `Withdraw` consegue alterar o saldo de uma conta já logada.  

Em `TestWithdrawWithoutLogin`, crie a lógica para verificar se a função `Withdraw` retorna uma exceção quando é executada sem uma conta logada.

Em `TestWithdrawWithoutBalance`, crie a lógica para verificar se a função `Withdraw` retorna uma exceção quando o saldo da conta não é suficiente.

</details>

## 4 - O programa deve transferir dinheiro entre contas
Crie a lógica do seu requisito no arquivo src/trybank/Trybank.cs.

<details>
  <summary>O programa deve permitir a transferência de saldo entre uma pessoa usuária logada e uma conta existente</summary><br />

Crie esse requisito na função `    public void Transfer(int destinationNumber, int destinationAgency, int value)
()`

**Se não houver uma pessoa usuária logada**, você deverá lançar uma exceção do tipo `AccessViolationException`, com a mensagem `Usuário já está logado`

Se o saldo da conta da pessoa usuária logada for insuficiente para fazer a transferência, você deve lançar uma exceção do tipo `InvalidOperationException` com a mensagem `Saldo insuficiente`

**Caso contrário**, a função deve transferir o valor passado por parâmetro do saldo da pessoa usuária logada para o saldo da conta passada por parâmetro.
</details>

<details>
  <summary>Crie os testes para a Transferência</summary><br />

Crie esse requisito em `src/trybank.Test/TestThirdReq.cs`

Em `TestTransferSucess`, crie a lógica para verificar se a função `Transfer` consegue alterar o saldo de uma conta já logada e mover o valor para outra conta passada por parâmetro.  

Em `TestTransferWithoutLogin`, crie a lógica para verificar se a função `Transfer` retorna uma exceção quando é executada sem uma conta logada.

Em `TestTransferWithoutBalance`, crie a lógica para verificar se a função `Transfer` retorna uma exceção quando o saldo da conta logada não é suficiente.

</details>

Este projeto envolve os conhecimentos de estruturas de controle condicional e de repetição, além das exceções e seu controle sobre o fluxo de trabalho. A partir deste desafio, você certamente será uma pessoa mais bem preparada para os desafios do mercado de trabalho! #VQV 🚀
