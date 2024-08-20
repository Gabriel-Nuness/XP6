+Confronto.
## Cenário

#### Arquitetura.
Arquitetura brutalista, formas básicas, materiais básicos e poucas cores.

![[Pasted image 20240625171659.png|250]] 
![[Pasted image 20240625171837.png | 250]]

Cidade conectada por pontes destruidas.
Prédios padrões e sem diferenciação.
Destroços de guerra.
+Baixo +Podre +Destruição.

![[Pasted image 20240625172400.png]]

#### Gameplay
* Sem loadscreen.
* Câmera fixa.
* As paredes, chão, teto... devem ser meshes separados para que a câmera possa ocultar quando ficar entre o jogador e ela.
	* Esses meshes estarão em camadas diferentes dos outros objetos e personagens.

![[Pasted image 20240625175754.png]]

##### Estados

**Fora**
* Câmera se move dependendo da livremente verticalmente e no eixo principal daquele lugar.
* Quando o jogador se distancia a mais de X do centro da câmera ela começa a seguir ele.

![[Pasted image 20240625173800.png]]

**Dentro**
* Câmera fixa em um pivot e muda apenas quando sai para outro espaço.
* Câmera se move livre verticalmente.

![[Pasted image 20240625174430.png]]

### Protagonista

##### Aparência.
* Andrógeno.
* Sem gênero definido.
* Sem nacionalidade.
* Sem raça.
* Vítima ou algoz?


### Confronto

##### Luz X sombra.
* As sombras tentam consumir tudo ao redor, mas em locais iluminados ou quando o jogador tem uma lanterna para se iluminar e afugentar as sombras por um período de tempo.
* Mini bosses.
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
	* Uma sombra agressiva que persegue a luz (mas não é imune a ela).
		* Qual a diferença de uma sombra normal?
			* Necessidade de usar outro objeto na hora do confronto.
			* Perigo ao redor de áreas protegidas.
			* Inimigo ativo.
			* Se torna mais presente e agressivo quanto mais porto do final "bom".
		* Forma de derrotar.
			* 
	* Uma sombra que imita luz.
		* Qual a diferença de uma sombra normal?
			* Surpresa.
			* Perigo em um local seguro.
			* Hazard que só é ativado quando o jogador chega próximo ou interage.
			* Se torna mais presente e agressivo quanto mais porto do final "bom".
		* Forma de derrotar.
			* 
* Formas de se salvar.
	* Lanterna.
	* Granada de luz.
	* Fugir.
	* 

![[Pasted image 20240626105104.png]]

###### Regras.
* Sombra e luz.
	* Nem toda sombra é agressiva, apenas as sombras que foram geradas pelas explosões.
	* As sombras se aglomeram em maior número perto das regiões de explosões e quanto mais baixo na cidade.
	* Todas as luzes espantam as sombras, mesmo as do sol (quando visível).
	* Criaturas únicas e mais poderosas podem ser derrotadas ou espantadas apenas com um nível de luz mais forte.
	* Em todas as regiões há um sistema de luz que pode ser ativo para espantar as sombras daquela região.
	* Níveis de luz.
		* Lanternas - fraco.
		* Bomba de luz - forte.
		* Sol - forte.
* A burguesia.
	* Biotecnologias.
	* Supercomputadores.
	* Naves.
	* Proativamente todas as tecnologias foram levadas para outro lugar quando evacuaram.
	* Todos foram evacuados da cidade antes do ataque.
	* 

	* Comunicação.
		* Bio-comunicadores.
		* Bio-Hologramas.
* Classe média.
	* Abandonados na crise.
	* Uma mistura das duas tecnologias.
	* Servos da burguesia.
	* Alguns conseguiram serem evacuados da cidade, a maioria não.
	* "Ideologia pequeno burguesa".
	* Vê na burguesia uma falsa salvação.
	* 

	* Comunicação.
		* Telefones.
		* Bio-comunicadores.
* Região baixa.
	* Fios.
	* Tecnologia digital.
	* Ou não foram evacuados devidamente ou voltaram por não ter onde ir.
	* Grupos revolucionários.
	* 

	* Comunicação.
		* Telefones.
		* Analógico.
			* Criptografia.
			* Mensagens espalhadas pelo cenário (em caso de confrontos).
			* 
###### Puzzles
* Cifras.
* Puzzle de chave.
* Senha pelo mapa.
	* Senha nos livros.
	* Senha em quadros.
	* Senha em padrões no mapa.
	* Gravações.
* 