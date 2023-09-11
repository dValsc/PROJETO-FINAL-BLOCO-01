using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produto
    {
        private int id;
        private string nome;
        private decimal preco;

        public Produto(int id, string nome, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }

        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }
        public string GetNome() { return nome; }
        public void SetNome(string nome) { this.nome = nome; }
        public decimal GetPreco() { return preco; }
        public void SetPreco(decimal preco) { this.preco = preco; }

        public virtual void visualizar()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Dados do Produto");
            Console.WriteLine("********************************************");
            Console.WriteLine($"ID Produto: {this.id}");
            Console.WriteLine($"Nome Produto: {this.nome}");
            Console.WriteLine($"Preço do Produto: {this.preco}");


        }
    }
}
