using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio

    {
        ContatoModel ListarPosId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contatol);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
            
    }
}
