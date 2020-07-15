Feature: Depósito de Cheques
       Eu como cooperado do Sistema Ailos
       Quero poder depositar cheques diretamente pelo aplicativo da minha cooperativa
       Para que não precise me locomover presencialmente até um posto de atendimento

Background: A cooperativa deve estar habilitada no Aimaro Web > Sistema Ailos > CHQMOB

@passou
Scenario: 1 - Habilitar a cooperativa para o serviço de Depósito de Cheques 
       Given Entrar no App Ailos e Selecionar uma cooperativa que foi habilitada para o serviço
       When Entrar na tela de Serviços do App Ailos em uma conta da respectiva cooperativa
       Then O menu de "Depósito de Cheques" deve ser apresentado

@bloqueado
Scenario: 2 - Adesão Manual do serviço
       Background A cooperativa deve estar com parâmetro "L - Liberação Depósito Mobile" no Aimaro Web > Cooperativa > CHQMOB selecionado como manual
       Given Entrar no App Ailos no menu de "Depósito de Cheques"
       And Realizar o processo de solicitação de adesão ao serviço
       Then Deve ser apresentado ao usuário que a solicitação foi enviada para análise
       And Deve ficar pendete dentro do menu "Produtos Mobile" na tela ATENDA da respectiva cooperativa da qual a conta pertence até que um colaborador efetue a liberação do serviço.

@passou
Scenario: 3 - Adesão Automática do serviço
       Background A cooperativa deve estar com parâmetro "L - Liberação Depósito Mobile" no Aimaro Web > Cooperativa > CHQMOB selecionado como automático
       Given entrar no App Ailos no menu de "Depósito de Cheques"
       And Realizar o processo de solicitação de adesão ao serviço
       Then Deve ser apresentado que a solicitação foi enviada para análise
       And O serviço deve ser automaticamente liberado para novos depósitos

@falhou
Scenario: 4 - Função Desabilitada
       Background Que o colaborar entre no Sistema Aimaro Web > ATENDA > Produtos Mobile > Opção Bloquear
       Given O usuário entrar no menu "Depósito de Cheques" no app Ailos
       When For apresentada uma tela explicando que a função está desabilitada
       Then O usuário não poderá ter nenhuma outra opção de interação nessa tela.

@falhou
Scenario: 5 - Depositar o cheque
       Background Que o cooperado possua liberãção para utilizar o serviço e tenha feito login no app
       Given O usuário deseje realizar o depósito de um cheque
       When Fotografar a parte frontal e traseira do cheque
       And Informar os dados de valor, CMC7 caso o SDK não tenha lido
       And O campo de identificação caso deseje
       Then O sistema deve realizar a validação dos dados informados considerando que o CMC7 deve possuir no máximo de 30 caracteres

@passou
Scenario: 6 - Cheque recusado
       Given Que o cooperado realizou o depósito de um cheque
       When Consultar o status do cheque no menu depósito de cheques do app ailos
       Then O sistema deve apresentar o respectivo cheque com o status recusado permitindo que o usuário possa informar novamente os dados do cheque com novas capturas

@bloqueado 
Scenario: 7 - Cheque aprovado
       Given Que o cooperado realizou o depósito de um cheque
       When Consultar o status do cheque no menu depósito de cheques do app ailos
       Then O sistema deve apresentar o respecitvo cheque com o status aprovado
       And o valor do cheque deve estar como saldo bloqueado no extrato do cooperado