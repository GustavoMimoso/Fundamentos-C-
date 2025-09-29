using ExemploFundamentos.Models;

//cast-casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");
//Console.WriteLine(a);

int quantidadeEmEstoque = 3;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");
if (possivelVenda)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada  em estoque.");
}







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