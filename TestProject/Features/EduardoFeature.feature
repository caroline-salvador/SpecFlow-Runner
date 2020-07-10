Feature: Deverá ser possível realizar o estorno de maneira digital nos Canais. 
         A função permitirá que o cooperado possa visualizar todos os pagamentos que foram feitos no mesmo dia,
         e caso necessário, clicar no pagamento e solicitar o estorno dele, desde que aquela guia seja passível de estorno.

Background: Logado na conta online com o usuário: "xxx" na conta: "859001" senha:00000000 Frase:0000000000 Letras: ABC

@passou
Scenario: 1 - Mostrar o comportamento para pagamento de FGTS que poderá ser estornado.
       Given que ao acessar o menu Pagamentos > Tributos > FGTS-Fundo de Garantia
       When realizar o pagamento da guia FGTS
       And acessar o menu Pagamentos > Outros> Estorno
       And será listado todos os pagamentos realizados
       Then para realizar o estorno o sistema deverá apresentar o botão "detalhes"
       And ao clicar no botão a opção de estorno deverá ser apresentado.

@passou
Scenario: 2 - Mostrar o comportamento para pagamento de CELESC que poderá ser estornado.
       Given que ao acessar o menu Pagamentos > Contas > Água,Luz,Telefone e Outras
       When realizar o pagamento da guia CELESC
       And acessar o menu Pagamentos > Outros> Estorno
       And será listado todos os pagamentos realizados
       Then para realizar o estorno o sistema deverá apresentar o botão "detalhes"
       And ao clicar no botão a opção de estorno deverá ser apresentado.

@passou
Scenario: 3 - Mostrar o comportamento para pagamento de DAE que poderá ser estornado.
       Given que ao acessar o menu Pagamentos > Tributos > DAE - Simples Doméstico/eSocial
       When realizar o pagamento da guia DAE
       And acessar o menu Pagamentos > Outros> Estorno
       And será listado todos os pagamentos realizados
       Then para realizar o estorno o sistema deverá apresentar o botão "detalhes"
       And ao clicar no botão a opção de estorno deverá ser apresentado.

@falhou
Scenario: 4 - Mostrar o comportamento para pagamento de TÍTULOS AILOS que poderá ser estornado.
       Given que ao acessar o menu Pagamentos > Contas > Boletos Diversos
       When realizar o pagamento da guia TÍTULOS AILOS
       And acessar o menu Pagamentos > Outros> Estorno
       And será listado todos os pagamentos realizados
       Then para realizar o estorno o sistema deverá apresentar o botão "detalhes"
       And ao clicar no botão a opção de estorno deverá ser apresentado.

@falhou
Scenario: 5 - Mostrar o comportamento para pagamento de DAS que não será possível realizar o estorno.
       Given que ao acessar o menu Pagamentos > Tributos > DAS - Simples Nacional
       When realizar o pagamento da guia DAS
       And acessar o menu Pagamentos > Outros> Estorno
       Then será listado todos os pagamentos realizados
       And  será apresentado em tela uma situação desse pagamento como "Não permitido"

@passou
Scenario: 6 - Mostrar o comportamento para pagamento de DARF 64/153/385 que não será possível realizar o estorno.
       Given que ao acessar o menu Pagamentos > Tributos > DARF- Receitas Federais
       When realizar o pagamento da guia DARF
       And acessar o menu Pagamentos > Outros> Estorno
       Then será listado todos os pagamentos realizados
       And  será apresentado em tela uma situação desse pagamento como "Não permitido"  

@passou
Scenario: 7 - Mostrar o comportamento para pagamento de DARE que não será possível realizar o estorno.
       Given que ao acessar o menu Pagamentos > Contas > Boletos Diversos
       When realizar o pagamento da guia DARE
       And acessar o menu Pagamentos > Outros> Estorno
       Then será listado todos os pagamentos realizados
       And  será apresentado em tela uma situação desse pagamento como "Não permitido"  

@falhou
Scenario: 8 - Mostrar o comportamento para pagamento de GNRE que não será possível realizar o estorno.
       Given que ao acessar o menu Pagamentos > Contas > Boletos Diversos
       When realizar o pagamento da guia GNRE
       And acessar o menu Pagamentos > Outros> Estorno
       Then será listado todos os pagamentos realizados
       And  será apresentado em tela uma situação desse pagamento como "Não permitido"  

@passou
Scenario: 9 - Mostrar o comportamento para pagamento de GPS que não será possível realizar o estorno.
       Given que ao acessar o menu Pagamentos > Tributos > GPS- Previdência Social
       When realizar o pagamento da guia GPS
       And acessar o menu Pagamentos > Outros> Estorno
       Then será listado todos os pagamentos realizados
       And  será apresentado em tela uma situação desse pagamento como "Não permitido"