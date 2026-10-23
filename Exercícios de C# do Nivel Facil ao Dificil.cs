Console.WriteLine("Nivel Facil");
Console.WriteLine();

Console.WriteLine("Digite um Numero Para Duplica-lo: ");
int numero = Convert.ToInt32(Console.ReadLine());
int resultado = numero * 2;
Console.WriteLine($"O Resultado é {resultado}");
Console.WriteLine("");

Console.WriteLine("Digite 2 Numeros Para Somar: ");
int numer1 = Convert.ToInt32(Console.ReadLine());
int numer2 = Convert.ToInt32(Console.ReadLine());
int resultado2 = numer1 + numer2;
Console.WriteLine($"O Resultado é {resultado2}");
Console.WriteLine("");

Console.WriteLine("Confirme se seu número é par ou ímpar: "); //Iniciação do programa para verificar se o número é par ou ímpar, usando o operador de módulo para verificar se o número é divisível por 2.
int numero3 = Convert.ToInt32(Console.ReadLine());
string resultado3 = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine($"o numero {numero3} é {resultado3}");
Console.WriteLine();

Console.WriteLine("Veja se sua idade é maior ou igual a 18 anos: ");
int idade = Convert.ToInt32(Console.ReadLine());
string mensagem = (idade >= 18) ? "Você é maior de idade." : "Você não é maior de idade.";
Console.WriteLine(mensagem);
Console.WriteLine();

Console.WriteLine("Nível Médio");
Console.WriteLine();

Console.WriteLine("Média de duas notas: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
double nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;
Console.WriteLine($"A média é {media}");
Console.WriteLine();

Console.WriteLine("Intervalo Númerico, indentifica se o numero está entre 50 e 100");   
Console.WriteLine("Digite um número: ");
int numero4 = Convert.ToInt32(Console.ReadLine());
string resultado4 = (numero4 >= 50 && numero4 <= 100) ? "Está no intervalo." : "Não está no intervalo.";
Console.WriteLine($"O número {numero4} {resultado4}");
Console.WriteLine();

Console.WriteLine("Veja se sua compra terá desconto: "); //Caso a comprar for igual ou maior de 100, terá um desconto de 10% no valor total da compra, caso contrário não terá desconto.
int valorCompra = Convert.ToInt32(Console.ReadLine());
string resultado5 = (valorCompra >= 100) ? $"Você terá um desconto de 10%, o valor final da compra é {valorCompra * 0.9}" : "Você não terá desconto.";
Console.WriteLine(resultado5);
Console.WriteLine();

Console.WriteLine("Escreva um número e descubra se ele é positivo ou negativo: "); //caso for somente 0 informaremos que o numero é 0
int numero5 = Convert.ToInt32(Console.ReadLine());
string resultado6 = (numero5 > 0) ? "É positivo." : (numero5 < 0) ? "É negativo." : "É zero.";
Console.WriteLine($"O número {numero5} {resultado6}");
Console.WriteLine();

Console.WriteLine("Leia sua idade, e veja se podera votar"); //ou seja ela necessita ter pelo menos 16 anos para votar, caso contrario não podera votar.
int idade2 = Convert.ToInt32(Console.ReadLine());
string resultado7 = (idade2 >= 16) ? "Você pode votar." : "Você não pode votar.";
Console.WriteLine(resultado7);
Console.WriteLine();

Console.WriteLine("Nível Difícil");
Console.WriteLine();

Console.WriteLine("Sistema de Login Simples");
Console.WriteLine("Digite seu nome de usuário:");
int Usuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite uma senha pra sua conta:");
int senha = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Conta criada com sucesso, {Usuario}!");
Console.WriteLine();

Console.WriteLine("Informe 3 números, e veja qual é o maior: ");
int numero6 = Convert.ToInt32(Console.ReadLine());
int numero7 = Convert.ToInt32(Console.ReadLine());
int numero8 = Convert.ToInt32(Console.ReadLine());
int maior = Math.Max(Math.Max(numero6, numero7), numero8); // dei uma pesquisada pra ver se tinha um comando que fasia isso
Console.WriteLine($"O maior número é {maior}");
Console.WriteLine();

Console.WriteLine("Calcule seu bonus de salário"); //Caso o salário seja maior que 2000, o bonus será de 10% do salário, caso contrário será de 20% do salário.
Console.WriteLine("Escreva seu sálario atual");
int Salario = Convert.ToInt32(Console.ReadLine());
int bonus = (Salario > 2000) ? (int)(Salario * 0.1) : (int)(Salario * 0.2);
Console.WriteLine($"Seu bônus de salário é {bonus}");
Console.WriteLine();

Console.WriteLine("Indentifique o ano Bissexto - Simples"); //Veja se é divisil por 4 sendo esse o criterio maximo
Console.WriteLine("Digite um ano:");
int ano = Convert.ToInt32(Console.ReadLine());
string resultado8 = (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0) ? "É um ano bissexto." : "Não é um ano bissexto.";
Console.WriteLine($"O ano {ano} {resultado8}");
Console.WriteLine();

Console.WriteLine("Validação de acesso");
Console.WriteLine("Digite sua idade");
int idade3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Voce recebeu um convite? (s/n)"); //Caso a idade seja maior ou igual a 18 e tenha um convite, o acesso será permitido, caso contrário não será permitido.  
string convite = Console.ReadLine();
string resultado9 = (idade3 >= 18 && convite.ToLower() == "s") ? "Acesso permitido." : "Acesso negado.";
Console.WriteLine(resultado9);
Console.WriteLine();

Console.WriteLine("Fim do programa");

