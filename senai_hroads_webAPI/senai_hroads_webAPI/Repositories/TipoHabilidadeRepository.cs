using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada)
        {
            TipoHabilidade TipoHabilidadeBuscada = ctx.TipoHabilidades.Find(idTipoHabilidade);

            if (TipoHabilidadeAtualizada.Tipo != null)
            {

                TipoHabilidadeBuscada.Tipo = TipoHabilidadeAtualizada.Tipo;
            }

            ctx.TipoHabilidades.Update(TipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        public TipoHabilidade BuscarPorId(int idTipoHabilidade)
        {
            return ctx.TipoHabilidades.FirstOrDefault(e => e.IdTipoHabilidade == idTipoHabilidade);
        }

        public void Cadastrar(TipoHabilidade novaTipoHabilidade)
        {
            ctx.TipoHabilidades.Update(novaTipoHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHabilidade)
        {
            TipoHabilidade TipoHabilidadeBuscada = ctx.TipoHabilidades.Find(idTipoHabilidade);

            ctx.TipoHabilidades.Remove(TipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
