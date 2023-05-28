# uspace-invaders

## Descrição
O jogador controla uma nave na parte inferior da tela cujo objetivo é atirar em
alienígenas que descem constantemente em direção à ele. Os inimigos se movimentam de
um lado a outro da tela antes de se aproximar mais um pouco do jogador. Alguns inimigos
podem atirar no jogador, que possui um número limitado de vidas. Se um alienígena atingir
a parte de baixo da tela o jogador perde.

### Metas cumpridas
- Deve ser um jogo digital, codificado a mão ou com auxílio de uma engine.
- Devemos ser capazes de jogar o seu jogo.
- O jogador deve poder movimentar horizontalmente uma nave.
- O jogador pode atirar um laser em linha reta para cima da tela.
- Os alienígenas devem aparecer da parte superior da tela. Eles se movem
horizontalmente e, quando a linha de alienígenas atingir o limite da tela, devem
descer mais um pouco na tela e andar na outra direção horizontalmente.
- Se um laser atingir um alienígena ele deve ser destruído.
- Se o jogador for atingido pelo laser de um alienígena ele deve perder uma vida.
- Se o jogador perder todas suas vidas ou um alienígena atingir a parte inferior da
tela, o jogo acaba.
- Poder pausar o jogo.
- Implementar pontuação do jogador. Ela é incrementada quando o jogador destruir
um alienígena. Os alienígenas podem conceder mais pontos quanto mais longe eles
estão da parte inferior da tela.
- Implementar tipos diferentes de inimigos (só andam, andam e atiram, podem receber
1 tiro sem morrer).

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

- O jogador enfrenta ondas de alienigenas, ao alcancar uma certa quantidade de pontos (no programa, 99, equivalente a 9 ondas),
ganha o jogo

A alteracao foi realizada para permitir, futuramente, um sistema que o jogo se torna infinito (em um estilo Shoot 'em up), com um melhor aumento na dificuldade
sem serem necessarias mais fases estaticas. O sistema de surgimento de ondas permitira que elas acelerem, aumentem em numero,
ou tenham mais inimigos que atiram, por exemplo. Alem disso, pode-se adicionar um sistema de upgrades para a nave do jogador
ou para estruturas de colisao (nao adicionadas), que pode ser comprado com os pontos ganhos.

--------------------
## O programa
- versao do unity: 2021.3.24f1 (LTS)

## Controles
- `<-, ->`
  - Controlam a nave para a esquerda e para a direita
- `Space`
  - Atira um laser para cima. Segurar o botao permite atirar continuamente
- `Esc`
  - Pausa o jogo, exibindo um menu que permite fechar o menu, reiniciar o jogo ou sair do programa.

## Bugs conhecidos
- Ao ganhar o jogo e clicar em "Restart", o jogo nao reinicia corretamente, continua pausado. Para reiniciar o jogo, pressione `Esc` para pausar e clique em reiniciar.

## Fontes
### Material Usado para aprendizado
- [Funcoes basicas do unity](https://www.youtube.com/watch?v=XtQMytORBmM&t=1069s&ab_channel=GameMaker%27sToolkit)
- [Configuracao de sprites, animacoes e co-rotinas](https://www.youtube.com/watch?v=JfICj5yp44k&list=PLfhbBaEcybmhGhADxKSqqliuCLg3xY_ep&ab_channel=Comp-3Interactive)
- [Detalhes dos componentes](https://docs.unity3d.com/Manual/UnityManual.html)

### Assets
- [Sprites](https://comp3interactive.itch.io/invaders-from-outerspace-full-project-asset-pack)
- []()
