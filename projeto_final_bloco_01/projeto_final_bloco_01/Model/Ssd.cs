using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Ssd: Produto
    {
        private string? marca;
        public Ssd(int id, string nome, decimal preco, string marca) : base(id, nome, preco)
        {
            this.marca = marca;
        }

        public string GetMarca() { return this.marca; }
        public void SetMarca(string marca) { this.marca = marca; }

        public override void visualizar()
        {
            base.visualizar();
            Console.WriteLine("Marca:" + this.marca);
        }
    }
}
