using System.Collections.Generic;

namespace Projeto.dominio {
    class Marca {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public List<Carro> carros;

        public Marca(int codigo, string nome, string pais) {
            Codigo = codigo;
            Nome = nome;
            Pais = pais;
            carros = new List<Carro>();
        }

        public void addCarro(Carro c) {
            carros.Add(c);
            carros.Sort();
        }

        public override string ToString() {
            return Codigo
                + ", "
                + Nome
                + ", País: "
                + Pais
                + ", Número de carros: "
                + carros.Count;
        }
    }
}
