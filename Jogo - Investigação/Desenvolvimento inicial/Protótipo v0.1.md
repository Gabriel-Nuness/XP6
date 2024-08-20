* Objetivo do protípo.
	* Inventário.
		* Puzzle.
		* Inimigos.
		* Puzzle + inimigos.
	* Sanidade.
		* O mapa muda quanto menos sanidade o jogador tiver.
		* Os inimigos sentem a baixa sanidade.

* Objetivo do jogo.
	* Dispersar as sombras que dominam a cidade.
* Trama.
	* Nas ruinas de uma civilização antiga, os mortos voltam em forma de sombras com a irá da destruição causada pela guerra.
	* O jogador chega para destruir as sombras, mas entende que elas são a consequência dessa guerra e deve a dispersar.
* Gameplay loop.
	* Investiga uma região.
	* Entende o ambiente.
	* Consegue passar para próxima região.
* Core loop.
	* Encontra um enigma.
	* Investiga a sala.
	* Encontra a resposta.
	* Passa para a próxima.
* Sanidade.
	* Embaralha a ordem das salas a cada 20% perdido.
	* Atrai mais sombras.
	* Quando zera.
		* Deixa os textos ilegíveis.
		* As pistas somem.
		* Embaralha todas as salas toda vez que muda de sala.
		* ~~Impossível ficar longe da luz.~~
		* ~~Reinicia o loop com 10% a menos de sanidade máxima (Não nesse protótipo).~~
	* Recupera quando.
		* Fica próximo de salas completamente iluminadas (pontos seguros).
		* Reinicia o loop (Não nesse protótipo).
		* Cigarro e drogas.
			* Mas...
			* Recuperação "falsa" da sanidade.
* Inimigo.
	* Sombras.
		* Consome sua sanidade.
		* Disperso pela luz.
		* Tem probabilidade de aparecer se o jogador ficar em uma sala escura, sem lampião e/ou com baixa sanidade.
			* Quanto mais para o centro, maior as chances.
		* Para derrotar.
			* Deve ligar o gerador e manusear a criatura para uma sala específica, então, nela, prende-la no sarcófago.
			
![[Pasted image 20240613221953.png]]

* Puzzle 1a - A entrada.
	* Uma cadeado que pede uma chave.
	* A "puzzle-key" foi dividida em 3 partes entre os três antigos moradores que sobreviveram para conseguir parar as sombras.
	* Os pedaços estão nas duas casas e na capela. 
		* Nesses ambientes, mostram os últimos momentos das pessoas até elas serem consumidas pelas sombras.
* Puzzle 1b - O lampião.
	* O lampião era de uma das pessoas que sobraram daquelas ruinas.
	* Ele está enterrado junto da pessoa morta no cemitério.
	* O cemitério começou a ser tomado pelas sombras, mas o caixão dessa pessoa em específico ficou protegido.
	* A senha está junto de cartas enviadas ao padre da cidade em uma pequena capela ao lado do cemitério.
* Puzzle 2a - Gerador.
	* Antes de entrar nas ruinas os sobreviventes falavam sobre um plano falho de ativar um sarcófago que liberaria a cidade das sombras.
	* Na entrada, é possível encontrar um mapa do cabeamento da cidade e do plano de redirecionar essa energia para o sarcófago.
	* O gerador está na parte norte do sarcófago, sem acesso ao mesmo por causa de destroços.
	* O gerador precisará do reator para funcionar.
	* O reator foi roubado por um homem que iria fugir e trafica-lo para "estrangeiros" que foram reesposáveis pela destruição da cidade.
	* O fugitivo deixou rastros até a entrada.
	* Na parte de fora da cidade, no porto, um barco abandonado e um corpo tomado pelas sombras estão jogados dentro da cabana.
	* O espião morreu antes de conseguir sair da cidade e sabotou o plano dos moradores.
* Puzzle 2b - Sarcófago.
	* A prisão está cercada por sombras e destruída pelo tempo.
	* Para restaurar o jogador deve encontrar o plano do sarcófago e achar as peças de reposição na casa do mecânico da cidade.
	* O porão dele estará trancado.
	* As chaves estavam com ele e ele estava, segundo cartas, próximo da região sul do sarcófago analisando o cabeamento do sarcófago.
	* Ele foi pego pelas sombras e morreu.
* Puzzle 3 - A sombra.
	* Quanto mais ao centro, mais concentrado são as sombras. Ao usar o gerador para expulsar as sombras das salas, elas se concentram mais nas outras.
	* Com isso, elas podem ser movidas para o sarcófago abandonado que seria a prisão dessas sombras.
	* A sala será tomada por uma forte sombra que, como um vento de um tornado, dificultará a movimentação do jogador até o centro e tentará apagar a chama que ele carrega. 
	* Ao ativar o sarcófago, as sombras são sugadas para dentro.