
### Verbos.
* Andar.
* Agachar.
* Empurrar.
* Rodar câmera.
* Abrir porta.
* Destrancar porta.
* Inspecionar item.
* Pegar item.
* Usar item.
* Iluminar área.
* Ligar/desligar luz.
* Colocar senha.
* Abrir/fechar caderno de anotações.
* Zoom in/out no caderno de anotações.
* Conversar.

### Câmera.
* Isométrica.
* Fixa, mas pode rotacionar...
	 * Para determinadas direções.
		* Mais controle do dev.
		* Menos chance de perder pistas.
		* Nenhuma opção do jogador.
	* Ao encontrar um objeto no cenário (alavanca?).
		* Menos chance de achar pista sem querer.
		* Mais chance de perder pista.
	* Cuidados.
		* Todos as paredes e chãos do cenário devem conseguir ser ocultados pela câmera quando o jogador ficar entre os dois.
		* Deve haver algum feedback de que o jogador ainda tem pistas para encontrar em certas salas.
		* As pistas que precisam apenas rotacionar a câmera devem poder ser encontradas sem querer (não podem ser pistas conclusivas, por exemplo).
		* Para aumentar a complexidade do jogo, alavancas mais avançadas no jogo podem revelar pistas em áreas anteriores.
			* É possível distorcer a regra anterior com isso?
			* Elementos metroidvania?

![[20240801-2314-31.0990227.mp4]]
![[Pasted image 20240813212115.png]]

Oclusão de objetos entre a câmera e o jogador.
![[Pasted image 20240625175754.png]]
### Movimentação.
* 8 direções.
* Andar e correr.
* Sem pulo.
* Agachar.
	* Passar por áreas menores.
	* Não ser detectado por inimigos.
	

### Inventário.
* Lista de itens pegos.
* Limite de X itens.
* Ao pegar um item novo, é anotado no carderno em uma lista de itens pegos.
* Os itens para serem pegos devem ser clicados em cima deles.
* Os itens são desenhados no caderno podendo ter escrito apenas a mensagem em caso de anotações.

![[Pasted image 20240930102141.png]]

### Iluminação.
* Quando o jogador pega a luz pela primeira vez ela fica em cima da cabeça dele o seguindo.
* Apertar o botão esquerdo do mouse em cima da luz liga ou desliga ela.
	* Quando não está seguindo o mouse, mantem uma distância fixa do jogador.
* Apertar com o botão direito trava e destrava a posição da luz.
* A luz pode ativar alguns tipos de dispositivos.
	* Outras luzes pelo cenário que precisam de energia.
		* Quando energizados são podem ser interagidos com o mouse diretamente. 
	* Mecanismos que usa de luz como ativador (portas, botões, sensores...) podendo ser.
		* Segurar (quando o mecanismo apenas fica ativo quando há luz em contato).
		* Flip-flop (ativando quando detectar e desativando quando detectar uma segunda vez)
		* Persistente (quando liga apenas uma vez e desliga de uma outra forma como tempo, outro sensor, clique...).
* A luz chama a atenção de NPCs tanto amigáveis quando hostis podendo ativar animações específicas ou ações na arvore de estados.
![[20240930-1324-31.3244062.mp4]]

* A luz tem uma área que é aproximadamente o tamanho da área (mais forte) da luz.
![[Pasted image 20240930102603.png]]
### Investigação.
[[Narrativa|Tipos de pistas podem ser encontradas aqui.]]
* Caderno de anotações.
	* Para abrir ou fechar o caderno o jogador deve apenas colocar o mouse sobre o caderno fechado e tirar de cima para fechar.
![[Pasted image 20240930105630.png]]
* Quando o jogador se encontra com um número X de pistas é anotado no caderno até achar a conclusão.
* Para encontrar as pistas o jogador deve interagir com elas ativando algum trigger como por exemplo:
	* Clicando em cima.
	* Falando com um NPC.
	* Desbloqueando uma nova área.
	* Pegando um item.
	* Interagindo com um objeto no cenário.
	* Ou qualquer outro trigger.
	
![[Pasted image 20240813222709.png]]

