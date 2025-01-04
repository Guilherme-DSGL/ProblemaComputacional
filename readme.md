# Projeto: Encontrar Elemento Repetido

## Descrição 
  O **Problema de Encontrar Elemento Repetido** consiste em verificar dado uma lista de números inteiros se existe algum número repetido nessa lista.

## Aplicabilidade Prática

Esse problema é aplicável em diversas áreas, como:

- **Validação de dados**: Identificar duplicatas em sistemas de cadastro de usuários ou inventários.
- **Análise de dados**: Detectar padrões repetitivos ou erros de entrada em grandes volumes de dados.
- **Otimização de algoritmos**: Evitar operações redundantes em processos que envolvem listas ou arrays.

## Algoritmos Implementados

- **Força Bruta**: O algoritmo força bruta testa todas as combinações possíveis verificando se algum deles é repetido.

- **Guloso**: O algoritmo guloso verifica ordena os números divide em duas coleções de pares e ímpares, e à medida que vai verificando ele toma a melhor decisão de verificar na coleção de par ou impar e adiciona o valor repetido.

- **Divisão e Conquista**: O algoritmo divide a lista em sublistas menores, verifica cada uma delas e depois retorna os resultados, usando a estratégia de dividir o problema em partes menores e resolver de forma recursiva.

## Observações

- O algoritmo **Força Bruta** é simples, mas pode ser ineficiente para listas grandes, pois explora todas as combinações possíveis.
- O algoritmo **Guloso** tende a ser mais eficiente do que a força bruta, mas pode não ser adequado para todos os casos dependendo da ordem dos elementos.
- O algoritmo **Divisão e Conquista** é eficaz para listas grandes, aproveitando a divisão recursiva do problema, mas pode exigir mais memória dependendo da implementação.




| Algoritmo              | Quantidade de Números | Eficiência         | Tempo de Execução | Consumo de Memória | Observações                                                                                  |
|------------------------|------------------------|--------------------|-------------------|--------------------|----------------------------------------------------------------------------------------------|
| Divisão e Conquista    | 1000                   | Alta               | 5ms               | 1,25 kB               | Consideravelmente rápido com baixa quantidade de números, mas perde para o algoritmo guloso   |
|                        | 100000                 | Alta               | 36ms              | 9 kB               | Se sai melhor comparado aos outros algoritmos quando utilizado um número maior de números     |
|                        | 1000000                | Alta               | 441ms             | 93  KB               | Considerávelmente rápido mesmo com números grandes                                                              |
| Guloso                 | 1000                   | Muito Alta         | 1ms               | 152 B               | O mais rápido quando utilizado com baixas quantidades de números                             |
|                        | 100000                 | Moderada           | 357ms             | 54 KB               | Relativamente rápido com quantidades de números consideráveis                                |
|                        | 1000000                | Alta               | 66311ms           | 510  KB              | Tempo de execução muito maior com números grandes                                            |
| Força Bruta            | 1000                   | Alta               | 2ms               | 90 B               | Rápido em baixas quantidades de números                                                      |
|                        | 100000                 | Baixa              | 22330ms           | 2,4 KB              | Deixa a desejar quando utilizado com grandes quantidades de números                          |
|                        | 1000000                | Muito Baixa        | 1200000ms (~20min)| 24 KB             | Tempo de execução muito alto, mais de 20 minutos para 1 milhão de números                   |
