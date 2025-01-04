# Projeto: Encontrar Elemento Repetido

## Descri��o 
  O **Problema de Encontrar Elemento Repetido** consiste em verificar dado uma lista de n�meros inteiros se existe algum n�mero repetido nessa lista.

## Aplicabilidade Pr�tica

Esse problema � aplic�vel em diversas �reas, como:

- **Valida��o de dados**: Identificar duplicatas em sistemas de cadastro de usu�rios ou invent�rios.
- **An�lise de dados**: Detectar padr�es repetitivos ou erros de entrada em grandes volumes de dados.
- **Otimiza��o de algoritmos**: Evitar opera��es redundantes em processos que envolvem listas ou arrays.

## Algoritmos Implementados

- **For�a Bruta**: O algoritmo for�a bruta testa todas as combina��es poss�veis verificando se algum deles � repetido.

- **Guloso**: O algoritmo guloso verifica ordena os n�meros divide em duas cole��es de pares e �mpares, e � medida que vai verificando ele toma a melhor decis�o de verificar na cole��o de par ou impar e adiciona o valor repetido.

- **Divis�o e Conquista**: O algoritmo divide a lista em sublistas menores, verifica cada uma delas e depois retorna os resultados, usando a estrat�gia de dividir o problema em partes menores e resolver de forma recursiva.

## Observa��es

- O algoritmo **For�a Bruta** � simples, mas pode ser ineficiente para listas grandes, pois explora todas as combina��es poss�veis.
- O algoritmo **Guloso** tende a ser mais eficiente do que a for�a bruta, mas pode n�o ser adequado para todos os casos dependendo da ordem dos elementos.
- O algoritmo **Divis�o e Conquista** � eficaz para listas grandes, aproveitando a divis�o recursiva do problema, mas pode exigir mais mem�ria dependendo da implementa��o.




| Algoritmo              | Quantidade de N�meros | Efici�ncia         | Tempo de Execu��o | Consumo de Mem�ria | Observa��es                                                                                  |
|------------------------|------------------------|--------------------|-------------------|--------------------|----------------------------------------------------------------------------------------------|
| Divis�o e Conquista    | 1000                   | Alta               | 5ms               | 1,25 kB               | Consideravelmente r�pido com baixa quantidade de n�meros, mas perde para o algoritmo guloso   |
|                        | 100000                 | Alta               | 36ms              | 9 kB               | Se sai melhor comparado aos outros algoritmos quando utilizado um n�mero maior de n�meros     |
|                        | 1000000                | Alta               | 441ms             | 93  KB               | Consider�velmente r�pido mesmo com n�meros grandes                                                              |
| Guloso                 | 1000                   | Muito Alta         | 1ms               | 152 B               | O mais r�pido quando utilizado com baixas quantidades de n�meros                             |
|                        | 100000                 | Moderada           | 357ms             | 54 KB               | Relativamente r�pido com quantidades de n�meros consider�veis                                |
|                        | 1000000                | Alta               | 66311ms           | 510  KB              | Tempo de execu��o muito maior com n�meros grandes                                            |
| For�a Bruta            | 1000                   | Alta               | 2ms               | 90 B               | R�pido em baixas quantidades de n�meros                                                      |
|                        | 100000                 | Baixa              | 22330ms           | 2,4 KB              | Deixa a desejar quando utilizado com grandes quantidades de n�meros                          |
|                        | 1000000                | Muito Baixa        | 1200000ms (~20min)| 24 KB             | Tempo de execu��o muito alto, mais de 20 minutos para 1 milh�o de n�meros                   |
