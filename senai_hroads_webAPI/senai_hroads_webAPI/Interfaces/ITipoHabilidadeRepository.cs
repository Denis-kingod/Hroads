using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();
        TipoHabilidade BuscarPorId(int idTipoHabilidade);
        void AtualizarIdUrl(int IdTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada);
        void Cadastrar(TipoHabilidade novaTipoHabilidade);
        void Deletar(int idTipoHabilidade);
    }
}
