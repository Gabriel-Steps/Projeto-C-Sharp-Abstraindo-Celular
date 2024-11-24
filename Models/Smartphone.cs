using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular.Models
{
    public abstract class Smartphone
    {
        public int Numero { get; set; }
        private string? Modelo { get; set; }
        private string? IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(int Numero, string modelo, string Imei, int memoria){
            this.Numero = Numero;
            Modelo = modelo;
            IMEI = Imei;
            Memoria = memoria;
        }

        public void ListarInformacoes(){
            Console.WriteLine($"Número: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemória: {Memoria}");
        }

        public void Ligar(){
            Console.WriteLine($"Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}