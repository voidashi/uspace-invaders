# uspace-invaders

## Descrição
O jogador controla uma nave na parte inferior da tela cujo objetivo é atirar em
alienígenas que descem constantemente em direção à ele. Os inimigos se movimentam de
um lado a outro da tela antes de se aproximar mais um pouco do jogador. Alguns inimigos
podem atirar no jogador, que possui um número limitado de vidas. Se um alienígena atingir
a parte de baixo da tela o jogador perde.

### Metas obrigatórias
- Deve ser um jogo digital, codificado a mão ou com auxílio de uma engine.
- Devemos ser capazes de jogar o seu jogo.
- O jogador deve poder movimentar horizontalmente uma nave.
- O jogador pode atirar um laser em linha reta para cima da tela.
- Os alienígenas devem aparecer da parte superior da tela. Eles se movem
horizontalmente e, quando a linha de alienígenas atingir o limite da tela, devem
descer mais um pouco na tela e andar na outra direção horizontalmente.
- Se um laser atingir um alienígena ele deve ser destruído.
- Se o jogador for atingido pelo laser de um alienígena ele deve perder uma vida.
- Se o jogador eliminar todos os alienígenas, ele ganha o jogo.
- Se o jogador perder todas suas vidas ou um alienígena atingir a parte inferior da
tela, o jogo acaba.

### Metas adicionais
- Fazer um menu inicial.
- Poder pausar o jogo.
- Implementar pontuação do jogador. Ela é incrementada quando o jogador destruir
um alienígena. Os alienígenas podem conceder mais pontos quanto mais longe eles
estão da parte inferior da tela.
- Se o jogador eliminar todos os alienígenas, ele pode passar de fase. Cada fase é
mais difícil que a anterior, com mais inimigos, inimigos mais rápidos ou mudanças do
gênero.
- Implementar tipos diferentes de inimigos (só andam, andam e atiram, podem receber
1 tiro sem morrer).
- Inserir no jogo um alienígena diferente que passa rapidamente no topo da tela de
tempos em tempos. Pontos extras ao jogador devem ser atribuídos quando o
alienígena especial for destruído.
- Inserir estruturas de colisão entre o jogador e os alienígenas que bloqueiam alguns
tiros.

### Metas nao cumpridas
- Fazer um menu inicial.
- Se o jogador eliminar todos os alienígenas, ele pode passar de fase. Cada fase é
mais difícil que a anterior, com mais inimigos, inimigos mais rápidos ou mudanças do
gênero.
- Inserir no jogo um alienígena diferente que passa rapidamente no topo da tela de
tempos em tempos. Pontos extras ao jogador devem ser atribuídos quando o
alienígena especial for destruído.
- Inserir estruturas de colisão entre o jogador e os alienígenas que bloqueiam alguns
tiros.

### Metas alteradas
- Se o jogador eliminar todos os alienígenas, ele ganha o jogo.

Alterado para

- O jogador enfrenta ondas de alienigenas, ao alcancar uma certa quantidade de pontos,
ganha o jogo

--------------------
## O programa

## Controles
- `<-, ->`
  - Controlam a nave para a esquerda e para a direita
- `Space`
  - Atira um laser para cima
- `Esc`
  - Pausa o jogo

## Fontes
### Material Usado para aprendizado
- [Funcoes basicas do unity](https://www.youtube.com/watch?v=XtQMytORBmM&t=1069s&ab_channel=GameMaker%27sToolkit)
- [Configuracao de sprites e corotinas](https://www.youtube.com/watch?v=JfICj5yp44k&list=PLfhbBaEcybmhGhADxKSqqliuCLg3xY_ep&ab_channel=Comp-3Interactive)

### Assets
- [Sprites](https://comp3interactive.itch.io/invaders-from-outerspace-full-project-asset-pack)
- []()
