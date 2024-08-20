#### Post mortem
	- Muitas classes separadas.
	- Ações simples parece ser feito de uma forma muito complicada para se ler.
	- Pensar melhor em quais cenários poderão existir antes de fazer a tool de cenário.
	- O banco de dado é muito útil e limpo, continuar usando.
	- O sistema do inventário é bem intuitivo, mas sofre por causa dos estados do personagem que não estão bem definidos (coisas que podem ser feitas apenas em um estado e coisas que podem ser feitas apenas em outro).
	- Pensar melhor nas utilidades de cada função (Por exemplo: O mapa não vai ser só em locais fechados, então para locais abertos não ficou claro como implementar).
	- Melhorar a busca por referências, não é bom ter que ficar colocando várias referências toda vez que um objeto novo é instanciado (MUITA DEPENDENCIA).
	- Ferramenta para criar itens?
	- A ferramenta de criar cenários pode ser mais customizável e utilizando menos partes separadas (fazer uma sala com um mesh apenas ou algo do tipo).

### Cenários
##### Lado de fora.
![[Pasted image 20240621230326.png]]
Vermelho - Chão, opaco.
Verde - Paredes, opaco ou semitransparente.
	Para mudar de uma sala para outra, pode se usar portas, portões ou buracos para caso esteja transacionando para um local fechado ou semi fechado.
	Transições entre locais abertos acontecem por meio de "area triggers" que cobrem toda lateral.
	São maiores do que as salas.
##### Lado de dentro.

Fazer a partir de coordenadas de tamanho e das paredes com porta, janelas, buracos, portões...

![[Pasted image 20240621225626.png]]
Vermelho - Chão,  opaco.
Laranja - Forro, completamente transparente.
Verde - Paredes da esquerda e superior, opaco.
Azul - Paredes da direita e da parte inferior, semi transparente.
	As paredes podem ser pequenas, médias ou grandes.
	Transições ocorrem por postas, buracos, portões...

### Personagem

##### UI
* 

##### Inventário
* Banco de dados.
* Tela de inspecionar.
* Bolsos, mão e bolsa.
* Pegar e soltar item.

##### Movimentação
* Aceleração < Desaceleração.
* Animação de 180°
* Usar rootmotion?
* 

##### Ações
* Pegar.
* Inspecionar.
* Andar/correr.
* Empurrar.
* Usar.

##### Estados
* Parado.
* Andando.
* Bolsa/Inspecionando item.
* Empurrando.
* Atacando.
* Usando objeto.
* Baixa sanidade.
* 0 sanidade.

#### Loop
* Stanely parable.
	* Cada loop é um final diferente.
	* Busca por segredos.
	* Caminhos diferentes para cada loop.
	* Apenas algumas falas mudam de uma run para outra.
	* Linearidade do mapa.
	* 
	
	![[Pasted image 20240622170257.png]]
	
* Outer wilds.
	* Loop temporal.
		* A cada 5/10/15/20 minutos tudo reseta.
	* Única coisa que se mantem é o diário.
	* Mapa extremamente aberto.
		* Poucas limitações para passar de uma área para outra.
	
![[Pasted image 20240622170600.png]]


###### Protótipo atual

![[Pasted image 20240622173428.png]]

##### Novas ideias
Vários finais:
* Foge.
* Chega e ativa o sarcófago sem juntar as sombras.
* Chega e ativa o sarcófago sem concertar.
* Ativa o gerador, concentra as sombras e ativa o sarcófago.

O que eu gosto dessa ideia?
* Esconder segredos que vão obrigar o jogador a ir atrás.
* Não existe "final errado".
* 

Quais são os possíveis problemas dessa ideia?
* Muitos finais para serem feitos diferentes.
* Muitas ramificações.
* 

Loop temporal:
* Mais aberto.
* A cada 15 minutos reinicia.
* Sem hardlocks.
	* Ou com hardlocks curtos.
* Em cada linha ações tem que ser tomadas para desbloquear o final verdadeiro.
	* 3 finais(?)
* Puzzles que travam caso feitos de maneira errada.
	* Nesses casos é importante não ser tão fácil travar o puzzle sem querer (pode ser que outra coisa se desbloqueie para ser explorada caso ele faça isso).

![[Pasted image 20240622184913.png]]
O que eu gosto da ideia?
* Explorar livremente.
* Poder ter puzzles mais difíceis.
* O jogador não ficar preso em um puzzle apenas podendo sair de um e ir para outro.
* Pode ter eventos que acontecem em momentos específicos.
* Locais podem ficar acessíveis em momentos específicos.

Quais são os possíveis problemas?
* Muito aberto e pode ser difícil de amarrar a história dessa forma.
* Pode ser frustrante ter que repetir a mesma ação todo loop.

Solução:

Uma ideia que tenha:
* Explorar livremente.
* Poder ter puzzles mais difíceis.
* O jogador não ficar preso em um puzzle apenas podendo sair de um e ir para outro.
* Pode ter eventos que acontecem em momentos específicos.
* Locais podem ficar acessíveis em momentos específicos.
* Esconder segredos que vão obrigar o jogador a ir atrás.
* Finais diferentes, nenhum "errado".

Mas que não tenha:
* Muito aberto e pode ser difícil de amarrar a história dessa forma.
* Pode ser frustrante ter que repetir a mesma ação todo loop.
* Muitos finais para serem feitos diferentes.
* Muitas ramificações.

 Ideias -
 * ==Vários finais (loop de finais) onde cada um vai ficando mais complexo do que o outro e tendo que encontrar mais segredos.==
 * Loop de tempo onde vários puzzles diferentes devem ser resolvidos para se chegar ao final (alguns finais não dependem de todos).

##### Ideia 1 

	*Sombras de hiroishima.
	*Guerra da Coreia.
Finais:
* Ser consumido pelas sombras dos sobreviventes e conversar com eles descobrindo que na verdade as sombras devem ser libertadas (mortas).
* Ser consumido pelas sombras.
* Ativar o sarcófago arrumado com as sombras da cidade e dos sobreviventes de fora.
* Ativar o sarcófago arrumado com as sombras da cidade.
* Ativar o sarcófago estando insano.
* Ativar o sarcófago quebrado.
* Ativar o sarcófago sem todas as sombras no local.
* Ser consumido por todas as sombras na sala sarcófago.
* Entende a realidade das sombras e suas histórias (país socialista), ele é um soldado visto como traidor pelas sombras, mandado para morrer. Para acabar com o loop, ele deve destruir o sarcófago junto das sombras.

###### Puzzles
* Puzzle 1
	* 
* Puzzle 2
	* 
* Puzzle 3
	* 
* Puzzle 4
	* 
* Puzzle 5
	* 