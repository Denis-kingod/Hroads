using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface IClassRepository
    {
        List<Class> Listar();
        Class BuscarPorId(int idClass);
        void AtualizarIdUrl(int idHabClass, Class ClassAtualizada);
        void Cadastrar(Class novaClass);
        void Deletar(int Class);
    }
}
