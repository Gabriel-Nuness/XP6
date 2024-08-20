
![[Pasted image 20240721195938.png]]
Pontos positivos.
* Local onde as pistas e conclusões podem ser armazenadas para não serem esquecidas.
* Facilita apontar ao jogador pontos de foco e direções.
* Bom feeling de usar.
* 

Possíveis problemas.
* Tamanho dos textos para decifrar.
* Cifra X anotações da investigação.
* Como a mecânica de pegar textos pelo cenário/carta se mistura com a cifra.
* Cifra de Cezar pode ser resolvida com "brute force".
* 

Desenvolver:
* ==Fazer o redesign do puzzle de cifra e do caderno de anotações para que os dois funcionem juntos.==
	* Cifra de vigenère.
		* Texto + chave.
	
	![[Pasted image 20240724215047.png]]


![[Pasted image 20240720154844.png]]
Pontos positivos.
* Os puzzles mais básicos são intuitivos (acender algo com a sua lâmpada).
* Ajuda na atmosfera de mistério e terror.
* Ajuda a esconder elementos mais longe.
* Casa bom com os puzzles de cifra.
* Bom para criar situações de risco X recompensa.
* A sombra funciona bem para esconder o cenário.

Possíveis problemas.
* Não funciona tão bem em combates.
	* Não requer habilidade para ser usado.
	* É infalível quando você aprende.
	* Ao encontrar um inimigo se torna impossível de combate-lo sem chamar a atenção de outros.
	* "*Ta, to segurando o inimigo. E agora?*"
* É impossível fazer qualquer coisa sem a lanterna se a sombra está no local.
* Pode acabar desfocando dos puzzles de cifra ("*Ah, queria decifrar esse puzzle, mas tem essa parte de sombras aqui*").
* Pode fazer o jogador ficar passando o mouse pela sala que nem maluco procurando pistas em cada canto (sem um ponto central naquele ambiente para o jogador começa a investigar o local).
* Quais vão ser as consequências dos conflitos?
	* Vida.
	* Sanidade.
	* Morte.
	* Loucura.

Desenvolver:
* ==Pensar se haverá confronto e como ele será.==
	* Outro item além da lanterna (bomba de luz).
	* Como a lanterna e as outras luzes influenciam? (nível de luminosidade).

Conflito
![[CombatIdeas.png]]
Ideias de inimigos.
Mini bosses.
* Observador.
	* Qual a diferença de uma sombra normal?
		* Sombra que interage com objetos.
		* Aparece quanto mais o jogador está com pouca sanidade.
		* Altera pistas e textos.
		* Espreita a região e pode ser afugentado com luz para outro local.
		* Se torna mais presente e agressivo quanto mais porto do final "bom".
		* Em alguns locais ele está presente mesmo com 100% de sanidade.
		* Há dicas nas interações com objetos que revelam a posição dele.
	* Forma de derrotar.
		* Ao retornar a 100% de sanidade ele desaparece temporariamente.
		* 
* ==Uma sombra agressiva que persegue a luz (mas não é imune a ela).==
	* Qual a diferença de uma sombra normal?
		* Necessidade de usar outro objeto na hora do confronto.
		* Perigo ao redor de áreas protegidas.
		* Inimigo ativo.
		* Se torna mais presente e agressivo quanto mais porto do final "bom".
	* Forma de derrotar.
		* A lanterna do jogador pode ser usada para criar um flesh de luz forte, mas por causa disso ela fica X segundos sem funcionar.
* Uma sombra que imita luz.
	* Qual a diferença de uma sombra normal?
		* Surpresa.
		* Perigo em um local seguro.
		* Hazard que só é ativado quando o jogador chega próximo ou interage.
		* Se torna mais presente e agressivo quanto mais porto do final "bom".
		* Chama outros inimigos.
	* Forma de derrotar.
		* 

==Redesignar as sombras para que elas casem com os puzzles e o combate ou retirar.==
* Apenas uma fumaça densa escura.

### Protótipo.
Fechar o design da investigação e puzzles.

Escopo:
* Sem inventário.
* Caderno de anotação.
* 

Narrativa:
* O que acontece nas minas?
* IA?
* Biotecnologias?
* Fim dos recursos.
* Descobrir a história de uma cidade.
* As pessoas são usadas para criar cérebros artificias que substituem os computadores gastando menos recursos.
* As pessoas usam essa luz para se guiar nas áreas mais baixas da cidade.
	* A fumaça gerada pela fábrica era quase viva e poderia ser espantada e queimada pelas lanternas.
	* A cidade servia como área de experimentos durante a guerra para armas biológicas.
	* As pessoas já tomadas pelas bactérias expelidas pela suposta mina de ferro da cidade começaram a ter mutações cada vez mais agressivas.
	* Como forma de testar a resistência das infecções, a cidade foi bombardeada.
	* O projeto foi um sucesso.
* Apenas essas pessoas com as luzes conseguiram fugir e se organizar.
	* Tecnologia guiada a luz.
	* Se separaram em 4 grupos para proteger os 4 portões da cidade.
	* Não tinham para onde ir então se organizaram.
		* Afeto pela cidade.
		* Falta de seus familiares.
		* Sem estrutura para sair daquele local.
* Tipo de pistas:
	* Cenário.
	* Placas.
	* Cartas entre personagens.
	* Anotações (Ex: "discurso para falar na plenária").
	* Diálogos escritos entre pessoas de turnos diferentes.


Vertical slice:
* Entrar na cidade.
* Ela foi trancada por moradores que conseguiram fugir.
* Alguns ficaram lá tentando cuidar 
* Religião naquele mundo.
* Movimentos sociais tentando organizar as pessoas.
* Unidade popular.
	* Acampamentos pela entrada.
	* Ocupando prédios do lado de fora.
	* Turnos de 3 pessoas.
	* Uma chave foi dado para cada família para proteger o portão.
* Grupos protegendo os 4 portões da cidade.
* Tramas.
	* Padre e militante.
	* Pessoa querendo fugir para tentar achar alguém dentro dos muros.
	* Pessoas de portões diferentes trocando cartas.
	* Outro portão foi destruído por algo.
	* Como esse acampamento foi destruído.
	* As mutações das pessoas.
		* Ouvir vozes de alguém dentro dos muros.
		* Força e resistência (corpo deformado).
		* Visão aguçada no escuro (sensibilidade a luz).
		* Ouvidos aguçados (cegueira).
* Puzzles.
	* Abrir o portão.
	* Chave.
	* Achar uma lanterna.
	* Portas que se abrem com luz.
	* Locais secretos que se abrem passando a lanterna em um caminho específico.
	* Cadeados com senha.
	* Arrastar objetos para liberar algo.
	* Algo escondido nas sombras.
	* Seguir pistas até uma pessoa.
	* 


Chave 1 - 
* Padre e militante.
* Debate sobre filosofia e política.
* Por que manter uma igreja em um futuro onde a fé não gera mais dinheiro?
* Esperança.
* Cemitério.
* Luz falsa.
	* Uma luz aparece no cemitério de vez em quando.
	* As sombras estão vazando para fora da muralha.
	* A luz chama pelo padre que se apega a sua fé.
	* Ele desaparece em uma noite após vagar pelo cemitério para resolver o vazamento.
	* A criatura aparece quando, dentro do cemitério, todas as luzes se apagam.
	* Ao chegar próximo...
		* A área é tomada por uma densa fumaça.
		* O cenário ao redor se torna um labirinto.
			* Dentro do labirinto há algumas pistas como:
				* O corpo do padre.
	* O que a fé cega pode levar.
* Ponto de vista do ocorrido.
	* A igreja foi bombardeada.
	* O partido organizou com os movimentos para evacuar as áreas de risco.
	* O padre organizou os fiéis para evacuar.
	* Ambos ficaram em um banker improvisado do partido.
Puzzle
* A chave está dentro do labirinto no corpo do padre.
* 

Chave 2 - 
* Pessoa querendo fugir para tentar achar alguém dentro dos muros.
* Procurar a filha.
* Cavando um buraco para entrar nos muros.
* Vozes de dentro dos muros.
* Entrada desmorona com o ataque de algo.
* Observador.
	* Outro vazamento de sombra ocorre.
	* Uma mãe que perdeu tudo está na sua cabana com outros moradores.
	* Ela acha a fenda e escuta gritos vindo de lá.
	* Seus sonhos são tomados por memórias do dia do bombardeio.
	* Ela busca ajuda do padre.
	* Sua mutação de audição faz com que ela ouça as vozes mesmo de longe.
	* Em uma noite, ela se aventura para dentro da rachadura e nunca mais volta.
	* Quando o jogador chega perto...
		* Quando o jogador esta próximo da criatura, seu caderno fica com outras anotações de pessoas diferentes, nele está escrito...
			* O local onde a criatura está.
			* A criatura conversa pelos textos.
			* A criatura tentando atrapalhar o jogador a acha-la.
			* A criatura tentando ajudar o jogador a resolver o enigma.
			* Pistas para uma armadilha.
				* O local onde ele está.
				* O jogador terá que enfrenta-lo para passar.
			* Local de pessoas perdidas dentro do muro.
				* A filha está lá.
				* A mãe a a filha se encontraram e conseguiram fugir.
				* A mãe conseguiu ajudar a filha a fugir.
			* ==Anotações criptografadas incompletas das pessoas que passaram por lá.==
			* As anotações ficam inúteis.
			* 
* Ponto de vista do ocorrido.
	* Sua filha estava na escola e ela estava trabalhando.
	* Ficou em um banker improvisado do partido.
Puzzle
* A chave está na cabana dela colado no muro.

Chave 3 - 
* Pessoas de portões diferentes trocando cartas.
* Outro portão foi destruído por algo.
* A pessoa em contato desapareceu.
* Relatos da caverna próxima das minas.
* Figura monstruosa.
	* A força militar não fugiu e tentou segurar a população a força.
	* Alguns soldados se expõem mais a fumaça.
	* Seu corpo é tomado pelas mutações e sua mente se apega aos ensinamentos militares.
	* Sua sede de repressão e ódio avança deixando vivo apenas aqueles que ele considera forte e digno.
	* *Mr. X.*
	* *Alien.*
* Ponto de vista do ocorrido.
	* As minas foram fechadas dias antes.
	* Ataques de misseis.
	* Ambos ficaram em um banker improvisado do partido em locais diferentes.
Puzzle
* A chave está 
* 