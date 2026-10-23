Console.WriteLine("(Enem) Jogar baralho é uma atividade que estimula o raciocínio. Um jogo tradicional é a Paciência, que utiliza 52 cartas. Inicialmente são formadas sete colunas com as cartas. A primeira coluna tem uma carta, a segunda tem duas cartas, a terceira tem três cartas, a quarta tem quatro cartas, e assim sucessivamente até a sétima coluna, a qual tem sete cartas, e o que sobra forma o monte, que são as cartas não utilizadas nas colunas.A quantidade de cartas que forma o monte é:");
int totalCartas = 52;
int cartasColunas = 7 * 8 / 2; // Soma das cartas em todas as colunas
int cartasMunte = totalCartas - cartasColunas; // Total de Cartas separadas menos o total de cartas nas colunas
Console.WriteLine("");
Console.WriteLine("A quantidade de cartas que forma o monte é:");
Console.WriteLine(cartasMunte); //Resultado
