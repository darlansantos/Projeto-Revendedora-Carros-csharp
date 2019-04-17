using System;
using System.Collections.Generic;
using System.Globalization;

namespace Projeto.dominio {
    class Carro : IComparable {
        public int Codigo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double PrecoBasico { get; set; }
        public Marca Marca { get; set; }
        public List<Acessorio> acessorios;

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca) {
            Codigo = codigo;
            Modelo = modelo;
            Ano = ano;
            PrecoBasico = precoBasico;
            Marca = marca;
            acessorios = new List<Acessorio>();
        }

        public double precoTotal() {
            double soma = PrecoBasico;
            for (int i=0; i<acessorios.Count; i++) {
                soma = soma + acessorios[i].Preco;
            }
            return soma;
        }

        public override string ToString() {
            String s = Codigo + ", " + Modelo + ", Ano: " + Ano
                + ", Preço básico: " + PrecoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: " + precoTotal().ToString("F2", CultureInfo.InvariantCulture);
            if (acessorios.Count > 0) {
                s = s + "\nAcessórios:";
                for (int i = 0; i < acessorios.Count; i++) {
                    s = s + "\n" + acessorios[i];
                }
            }
            return s;
        }

        public int CompareTo(object obj) {
            Carro outro = (Carro)obj;
            int resultado = Modelo.CompareTo(outro.Modelo);
            if (resultado != 0) {
                return resultado;
            }
            else {
                return -precoTotal().CompareTo(outro.precoTotal());
            }
        }
    }
}
