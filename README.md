# Exercicios-ProcessoSeletivo
Como parte de um processo seletivo para a vaga Formação de talentos, foi necessária a implementação de 3 exercícios para o desafio prático. Os enunciados estão documentados em ReadMe, junto com a descrição de cada implementação.

1) A ModalGR possui um sistema em desenvolvimento para um restaurante e
numa parte específica será necessário calcular o valor da refeição realizada pelo
cliente, retornando uma mensagem no seguinte formato:
O prato de x gramas custa: R$x,yz
Visando atender esse quesito, você foi escolhido para nos ajudar nessa solução!
A ideia é ter 3 campos: um para inserção do valor do quilo, outro para a tara do
prato e o último para o peso do prato (refeição), e em seguida, exibir a mensagem
no padrão exigido.
Observações:
➢ O valor do prato deve conter duas casas decimais após a virgula;
➢ Lembre-se de descontar a tara do prato no peso da refeição, para assim
calcular o valor corretamente a ser pago.


2) A ModalGR possui um sistema em desenvolvimento e numa parte específica
será necessário separar dados numéricos de strings, a partir de uma variável do
tipo string contendo diversos valores delimitados por vírgula, como por exemplo:
Ana, 89,78, Maria, 45.8, 27, 56, Paula Pereira, 978, A, VIVA, 35, 125, 8999, ...
Visando atender esse quesito, você foi escolhido para nos ajudar nessa solução!
Após a separação dos dados exibi-los em tela.
Observação:
➢ O tamanho da string com os dados base é variável, ou seja, não possui
um limite fixo.

3) A ModalGR participará de uma feira de tecnologia e cerca de 150 de seus
colaboradores comparecerão. Portanto, como exigência dos organizadores é
necessário que todos estejam devidamente identificados, através de um crachá
contendo o logo da ModalGR e o respectivo nome do colaborador em maiúsculo,
o qual deverá respeitar o seguinte padrão como segue no exemplo abaixo:
Nome completo colaborador: Antônio Carlos Pereira da Silva dos Santos e
Machado
Nome que deverá ser impresso no crachá: MACHADO, A. C. P. S. S.
Visando atender essa exigência, você foi escolhido para nos ajudar nessa
solução!
A ideia é ter um campo para inserção do nome completo do colaborador, e em
seguida, exibi-lo no padrão exigido.
Observações:
➢ Conectores de nomes (de, da, das, do, dos, e) devem ser
desconsiderados;
➢ A quantidade de nomes de um determinado colaborador não deve afetar
o funcionamento real da solução.

=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
Resolução e comentários
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-


1) Foi implementado na linguagem C# através do software Microsoft Visual Studio 2022, com base de programação orientada a objetos, foi implementado:

- Validação de dados por KeyPress, permitindo apenas números, "," e o botão backspance para evitar bugs da aplicação por mal uso;
- Validação se o campo estiver vazio;
- Botão Limpar com reset dos dados e foco no Textbox principal;
- Botão Calcular que faz o cálculo conforme a necessidade da aplicação;
- Botão Fechar alternativo que pergunta primeiro se o usuário tem certeza que deseja fechar o programa;
- Botão de ajuda que explica ao usuário através de um MessageBox como utilizar o programa;
- Tabindex que permite a navegação correta via teclado;
- Modificação de propiedades, visuais e funcionais menos significativas.

2) Criado e desenvolvido na linguagem Python pelo software PyCharm, Implementações:

- Menu de controle;
- Foi utilizado o método split() para separar a lista por ",";
- Uma estrutura de controle que verifica se o índice é uma string ou um número ao tentar dividi-lo, através do try/except para não ocorrer bugs;
- Estrutura de repetição para poder ser realizado infinitas conversões.

3) Desenvolvido em JavaScript pelo software Visual Studio Code, implementações:

- Documentação da página web em HTML5;
- Estilização em CSS;
- Botão que gera o crachá;
- Botão Limpar que zera o campo, o crachá e da o foco novamente ao campo;
- Botão de imprimir o crachá (Não fazia parte do exercício);
