### Argumento
Protótipos com diversos puzzles sobre decifrar mensagens e coloca-las em um prompt (lies lies lies + cube escape).

### Gameplay

##### Gameplay loop
Nova tela > Achar as mensagens escondidas > descriptografar > próxima tela...

##### Core loop
Interageir com a tela > encontrar mensagens > entender qual tipo de criptografia > descriptografar.


#### Conceito
Várias telas onde o jogador pode usar de diversos objetos que estão em seu inventário e podendo interagir com o cenário para desvendar as mensagens escondidas para no final encontrar o texto perdido.

#### Criptografia.
* Medalhão de Cezar.
	* Um medalhão que, ao colocar a chave, número de 1 a 25, mostra a ordem que o texto deve ser descriptografado.
* Tabuleiro de xadrez.
	* 
* Livros.
	* Linha - palavra - letra.
	* Alguns livros estarão a disposição para serem inspecionados.
	* Ao encontrar a coordenada da letra, o jogador poderá desvendar o texto.
* Telefone.
	* Após achar um número em outro enigma, usando o telefone que pode ser achado em algumas telas, é possível encontrar uma gravação.
* Tabela de substituição.
	* Uma tabela que mostra qual versão embaralhada do alfabeto deve ser usado.
	* A tabela pode ser encontrada em listas de tabelas e, ao saber qual é a certa, pode ser utilizada para traduzir o texto.
* Tabela de vigenere.
![[Pasted image 20240712131932.png]]

#### Interação com o cenário.
* Mover objetos.
	* 
* Inspecionar.
	* Ler textos.
	* Olhar objetos.

### Post mortem
* Colocar atrás de algo é a forma mais fácil, depois de deixar visível na cena, de esconder uma das letras.
* É bom a chave estar contextualmente separada das letras (caso a chave não seja algo como um número).
* Facilitar/deixar satisfatório o manejo das letras e das palavras.
	* ==Talvez uma canvas== onde você pode arrastar letras para formar palavras, arrastar palavras para formar frases e descriptografar essas letras e símbolos.
* O desafio e a dificuldade deve ser em achar esses textos, como descriptografar e a organização desses textos decifrados, não o ato em si de decifrar.
* As palavras e letras não precisam estar na ordem certa, parte do desafio deve ser organizar as letras e palavras.
* ==Não (parece) ser um problema, ao decifrar parte do texto, você deduzir o resto caso essa dedução necessite de mais entendimento sobre as regras (não seja algo extremamente óbvio).==
* Ter mais de um puzzle para decifrar pode ser bom para caso o jogador fique travado em um, mas ==essa quantidade não pode chegar ao ponto do jogador se sentir overwelming== 
* Ideias retiradas dos testes.
	* Mover objetos para formar uma letra, símbolo ou número.
	* Objetos que podem ser inspecionados.
	* Interação com o próprio objeto que será decifrado (ex: uma seta que aponta para uma letra criptografada).

#### Puzzle
1. Atrás de objetos.
2. Inspecionar.
3. Organizar os objetos da cena.
4. Uma chave por letra.


*Tipo de jogadores.
*Dar uma "escolha" para o que o jogador vai fazer.
*Fazer a história esperar o jogador estar pronto.
*Textos curtos ou fragmentados.
*Contextualiza a história - Apresenta uma pista importante sobre aquela história - aponta para uma direção nova.
*Separar a história em arcos dividitos geograficamente.
*Nível de conteúdo - Superfícial, infermediario e avançado.
*Superfícial - Apresenta ao jogador um mistério, poucas respostas, muitas perguntas.
*Intermediário - Avança a história, conecta com outros mistérios.
*Avançado - A recompensa, a/as resposta(as).
*Definir pilares e "goals"