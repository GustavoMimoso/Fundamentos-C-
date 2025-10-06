using System.Runtime.InteropServices.Marshalling;
using ExemploFundamentos.Models;



















// int numero = 10;

// for (int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
// }


// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(20, 45);
// calc.Divisao(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numeroDeIncremento = 10;

// Console.WriteLine(numeroDeIncremento);

// Console.WriteLine("Incrementando o 10");
// // numeroDeIncremento = numeroDeIncremento + 1;
// numeroDeIncremento++;

// Console.WriteLine(numeroDeIncremento);

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine("Decrementando o 10");
// // numeroDecremento = numeroDecremento - 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);


// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }


// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = true;
// bool possuieAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuieAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }









// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "u":
//     case "e":
//     case "i":
//     case "o":
//         Console.WriteLine("Vogal!");
//         break;
//     default:
//         Console.WriteLine("Não é um vogal");
//         break;
// }













// Console.WriteLine("Digite um numero");
// String letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }




//cast-casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");
//Console.WriteLine(a);

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0  && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");
// if (quantidadeCompra == 0)
// {
//    Console.WriteLine("Venda Invalida, é necessario ao menosnuma unidade");
// }

//  else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada  em estoque.");
// }







// string a = "15";
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);




//cast implicito
// int a = 5;
// double b = a;

// int a = 5;
// long b = a;
// //ao contrario daria erro pois nao cabe o long dentro de int
// Console.WriteLine(b);




//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

// int a = 10;
// int b = 20;
// int c = a + b;

//c = c + 5;  = 30+5

//c += 5;
//c -= 5;
//c *= 5;


//Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(12);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Ola, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: "+ quantidade);
// Console.WriteLine("Valor da variavel altura: "+ altura);
// Console.WriteLine("Valor da variavel preco: "+ preco);
// Console.WriteLine("Valor da variavel condicao: "+ condicao);
// //Pessoa pessoa1 = new Pessoa();

// //pessoa1.Nome = "Gustavo";
// //pessoa1.Idade = 23;
// //pessoa1.Apresentar();