using System.Runtime.InteropServices.Marshalling;
using ExemploFundamentos.Common.Models;



List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição n° {contadorForeach} - {item}");
}

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}");
// }



// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
//     contadorForeach++;
// }


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Mimoso";
// pessoa1.Idade = 23;
// pessoa1.Apresentar();

// string opcao;
// bool exibirMenu = true;
// while(exibirMenu)
// {
//     Console.WriteLine("Digite sua opcao: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;   
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;    
//         default:
//             Console.WriteLine("Opcao Invalida");
//             break;    

//     }
// }

// Console.WriteLine("O programa se encerrou!");


























// int soma = 0, numero  = 0;

// do 
// {
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());
    
//     soma += numero;

// } while(numero !=0 );

// Console.WriteLine($"Total da soma dos numeros digitados e: {soma} ");

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }

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
