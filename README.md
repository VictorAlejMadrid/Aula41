# Questões Aula 41

## 1. O que é encoding? Por que ele é importante? O que muda ao interpretar um arquivo com encoding's diferentes?

Encoding define como o código será decodificado ou codificado, por exemplo, se utilizaremos caracteres uft8 ou utf16. A forma como isso é definido muda completamente a forma como um arquivo é interpretado, já que, dependendo da codificação, um arquivo pode possuir caracteres completamente diferentes.

## 2. Explique a diferença entre UTF8, Unicode e ASCII. Em que situações você usaria cada um deles?

ASCII - A codificação ASCII foi uma das primeiras tentativas de padronização das codificações utilizada pelos computadores. Nela existem 128 caracteres, variando de letras (maiúsculas e minúsculas), números e alguns caracteres especiais.
Ela é utilizada para textos/informações pouco complexas ou em situações de pouca memória, já que ela não possui muitos dados e também por ocupar pouco espaço de memória.

Unicode - O Unicode é uma codificação que permite uma maior variedade de caracteres para conseguir suprir uma maior variedade de linguagens em uma codificação apenas, (também permite emojis). Ele pode ser utilizado para gerar caracteres mais complexos e textos informais com emojis. Ele possui diversas variações para tentar suprir todas as variações linguísticas, como UTF-7, UTF-8, UTF-16 e etc...

UTF8 - É uma das codificação do Unicode que possui comprimento variável de 1-4 bytes. Ela suporta ASCII e caracteres do Plano Multilingual Básico, que possui os caracteres mais comuns no mundo. Esta codificação se torna leve para textos pouco complexos (com caracteres comuns), mas também pode suprir a necessidade dos caracteres mais complexos que requerem maior uso de espaço para serem representados.

## 3. O que é uma biblioteca de classes em C# e como ela difere de outras formas de organização de código?

Uma biblioteca de classes é um código modular que possui uma solução que pode ser distribuída e utilizada por outros programas para sua implementação sem necessitar da construção do zero por parte do utilizador. Esses códigos facilitam a implementação de códigos complexos ou comumente utilizados sem que hajam a replicação deste código do zero ou repetição de código por parte do desenvolvedor.

## 4. O que aconteceria se você tentasse abrir um arquivo que não existe usando a classe File em C#? Como que podemos tratar esse tipo de situação?

A função retornaria uma exceção, deste modo seria necessário tratar este erro utilizando o try-catch para direcionar o código caso este erro ocorra.

## 5. Quais são os pros e cons de usar bibliotecas próprias versus bibliotecas de terceiros no .NET?

As bibliotecas próprias tem vantagem de você possuir o conhecimento do código escrito e possuir controle sobre ele caso seja necessário alguma alteração. 
Já as bibliotecas de terceiros possuem a vantagem de não ser necessário a construção de um código do zero, poupando tempo e facilitando a implementação. Porém, as bibliotecas de terceiros podem possuir bugs e problemas de performance que dificultam a sua correção por serem de terceiros. 

## 6. O que são níveis de visibilidade em bibliotecas C# e por que eles são importantes para a segurança do código?

Os níveis de segurança são importante pois não permitem que dados sensíveis para o funcionamento do código sejam alterados ou vistos por quem está utilizando a biblioteca. Esses níveis permitem que o desenvolvedor defina quais partes do código poderão ser alterados pelo utilizador da biblioteca.

## 7. O que é uma DLL e como ela pode ser usada para compartilhar funcionalidades entre projetos em C#?

Uma DLL nada mais é que o resultado da compilação de uma biblioteca de código em C#. Este arquivo pode ser utilizado para compartilhamento de bibliotecas de código de forma simples e rápida, sem precisar passar pelo nuget.

## 8. Crie uma DLL chamada "TemperatureDLL" que contém uma classe "TemperatureConverter" com métodos para converter temperaturas entre Celsius, Fahrenheit e Kelvin. Utilize esta DLL em um projeto separado. (podem estender o código já desenvolvido em exercício anterior ou reescrever do zero, como preferirem)

Implementado no código.

## 9. Como fazemos comentários especiais em c# utilizados para documentar classes?

Fazemos por meio de 3 barras de comentário com utilização de XML, onde pode ser definido informações específicas da classe, assim como documentar variáveis e retornos de uma função.
Exemplo: 
/// <summary>resumo da função</summary>
/// <param name="<var>"> descrição de um parâmetro</param>
/// <returns>retorno da função</returns>


## 10. Estenda o exercício 08 adicionando comentários especiais para documentar a TemperatureDLL.

Implementado no código.

## 11. Qual é o propósito de um buffer ao trabalhar com fluxos de dados em C#? Dê um exemplo de quando o uso de buffers pode ser vantajoso.

Um buffer é utilizado para reduzir o processamento realizado pela máquina em que o programa está rodando. Esta ação auxilia na entrega de dados por partes enquanto um conjunto de dados grande não é totalmente carregado. Um exemplo de buffer é os próprios vídeos do youtube, já que eles não são totalmente enviados ao computador de uma vez e sim por partes, reduzindo o processamento por parte do computador e reduzindo o esforço do servidor do youtube. 

## 12. O que é um JSON? Por que é importante entendermos sobre ele?

JSON é a forma mais comum de fluxo de dados, ele representa dados por meio de objetos key-value. Por meio do JSON podemos receber e transmitir dados pela web.

## 13. Implementado no código

## 14. Crie uma biblioteca de classes chamada "MySuperbLib" que contém uma classe "Calculator" com métodos para adicionar, subtrair, multiplicar e dividir dois números. Utilize essa biblioteca num outro projeto.

Implementado no código

## 15. O que é o Nuget e como você pode distribuir seu código como um pacote do Nuget?

O Nuget é a plataforma onde é possível fazer a distribuição de nossos códigos ou implementar códigos de terceiros em nosso programa.
Para distribuir, basta ir em configurações do projeto, aceitar a criação de um arquivo nuget ao compilar e compilar uma biblioteca de classes para depois inserir o arquivo .nupkg gerado no site nuget.org/packages/manage/upload.















