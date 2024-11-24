using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(int numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"O aplicativo {nome} foi instalado no Iphone");
        }
    }
}