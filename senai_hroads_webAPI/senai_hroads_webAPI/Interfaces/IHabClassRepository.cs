using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface IHabClassRepository
    {
        List<HabClass> Listar();
        HabClass BuscarPorId(int idHabClass);
        void AtualizarIdUrl(int idHabClass, HabClass HabClassAtualizada);
        void Cadastrar(HabClass novaHabClass);
        void Deletar(int idHabClass);
    }
}
