using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizada)
        {
            TipoUsuario TipoUsuarioBuscada = ctx.TipoUsuarios.Find(idTipoUsuario);

            if (TipoUsuarioAtualizada.Titulo != null)
            {
                TipoUsuarioBuscada.Titulo = TipoUsuarioAtualizada.Titulo;
            }

            ctx.TipoUsuarios.Update(TipoUsuarioBuscada);

            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.TipoUsuarios.FirstOrDefault(e => e.IdTipoUsuario == idTipoUsuario);
        }

        public void Cadastrar(TipoUsuario novaTipoUsuario)
        {
            ctx.TipoUsuarios.Update(novaTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            TipoUsuario TipoUsuarioBuscada = ctx.TipoUsuarios.Find();

            ctx.TipoUsuarios.Remove(TipoUsuarioBuscada);

            ctx.SaveChanges();
        }
        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
