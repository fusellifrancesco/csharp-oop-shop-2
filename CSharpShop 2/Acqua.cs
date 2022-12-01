using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop_2 {
    public class Acqua : Prodotto{

        private double contenutoBottiglia;
        private string sorgente;
        private double contenutoMaxBottiglia = 1.5;

        public Acqua (string nome, string descrizione, double prezzo, double IVA, string sorgente, double contenutoBottiglia, double contenutoMaxBottiglia) : base(nome, descrizione, prezzo, IVA) {
            this.sorgente= sorgente;
            this.contenutoBottiglia = contenutoBottiglia;
            this.contenutoMaxBottiglia = contenutoMaxBottiglia;
        }

        // GETTERS

        public string GetSorgente() { 
            return this.sorgente;
        }

        public double GetContenutoBottiglia() {
            return this.contenutoBottiglia;
        }

        public double GetContenutoMaxBottiglia() {
            return this.contenutoMaxBottiglia;
        }

        // SETTERS

        public void SetContenutoBottiglia(double contenutoBottiglia) {
            if (contenutoBottiglia <= GetContenutoMaxBottiglia()) {
                this.contenutoBottiglia = contenutoBottiglia;
            } else {
                this.contenutoBottiglia = GetContenutoMaxBottiglia();
                Console.WriteLine("Ti si è rovesciata l'acqua per terra!");
            }
        }

        // METODI

        public void Bevi(double acquaDaBere) {
            if (acquaDaBere <= GetContenutoBottiglia() && acquaDaBere > 0) {
                double acquaRimasta = GetContenutoBottiglia() - acquaDaBere;
                this.contenutoBottiglia = acquaRimasta;
            }
        }




    }
}
