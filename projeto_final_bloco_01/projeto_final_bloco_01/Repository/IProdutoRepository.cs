﻿using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IProdutoRepository
    {
        public void CriarProduto(Produto produto);
        public void ListarTodosProdutos();
        public void ConsultarProdutoID(int id);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int id);
    }
}
    
