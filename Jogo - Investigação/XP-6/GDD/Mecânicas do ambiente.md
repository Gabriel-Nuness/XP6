
### Objetos móveis
* Objetos móveis são objetos pesados que o jogador não consegue pegar, mas que são leves o suficiente para que possam ser movidos (não passando de 3~4 players de peso).
* O jogador deve se colocar em um dos lados do objeto para que possa puxar ou empurrar o objeto.
* Quando nesse estado, ele não pode fazer mais nenhuma ação além de andar para frente e para trás e parar de empurrar.
* Para começar a empurrar o jogador apenas precisa andar em direção ao objeto e segurar o botão *esquerdo do mouse*.
* Para sair da interação é necessário apenas soltar o botão.

![[Pasted image 20240910181705.png]]

### Construção do mapa
* O mapa é separado em salas que podem ser cômodos de um prédio ou parte uma área aberta como um andar em um complexo de prédios.
* Triggers no limite do da área, portas, janelas ou buracos podem mandar o jogador para outra sala.

![[Pasted image 20240910183550.png]]

![[Pasted image 20240910182829.png]]

### NPCs

#### NPCs amigáveis
* NPCs amigáveis ficam em um local fazendo suas ações de maneira repedida até que algo seja feito para que mude seu estado.
![[Pasted image 20240927220435.png]]

##### Diálogo
* Ao interagir com algum NPC, uma caixa de diálogo aparecerá. 
* Diálogos são lineares e o jogador não tem opção de escolhas, mas triggeres pelo cenário (encontrar novas áreas, pegar itens, falar com outros NPCs...) podem desbloquear novos diálogos.
* Triggers também podem ser ativados por diálogos (receber um item, abrir uma porta, desbloquear um diálogo, fazer outro NPC agir, abrir um menu específico...).

#### NPCs hostis
Cada área do jogo terá um inimigo central que será o principal obstáculo do jogador naquele local. 
#### Boss #1
* O que ele faz?
	* Fica fixo em um local protegendo algo, quando o jogador chega perto ele...
* Como derrotar?
	* O jogador deve empurrar...
	* O jogador deve ativar uma luz...
	* Desligar...

#### Boss #2
* O que ele faz?
	* Anda por uma área...
	* Manda o jogador para algum outro local (pode ajudar na investigação?)
* Como derrotar?
	* Prende em um local e liga luzes fortes.

### Boss #3

![[Pasted image 20240925130752.png]]

#### Boss #4
* O que ele faz?
	* Um bicho quadrupede que territorialista que...
* Como derrotar?
	* Prender dentro de uma jaula.