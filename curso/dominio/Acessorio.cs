using System.Globalization;

namespace Projeto.dominio {
    class Acessorio {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Carro Carro { get; set; }

        public Acessorio(string nome, double preco, Carro carro) {
            Nome = nome;
            Preco = preco;
            Carro = carro;
        }

        public override string ToString() {
            return Nome
                + ", Preço: "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
