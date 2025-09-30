using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar( int x , int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x*y}");
        }
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}