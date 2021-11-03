using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class HabClassRepository : IHabClassRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void AtualizarIdUrl(int idHabClass, HabClass HabClassAtualizada)
        {
            HabClass habilidadeclassBuscada = BuscarPorId(idHabClass);

            if (HabClassAtualizada.IdHabilidade != null && HabClassAtualizada.IdClasses != null)
            {

                habilidadeclassBuscada.IdHabilidade = HabClassAtualizada.IdHabilidade;
                habilidadeclassBuscada.IdClasses = HabClassAtualizada.IdClasses;

            }

            ctx.HabClasses.Update(habilidadeclassBuscada);

            ctx.SaveChanges();
        }

        public HabClass BuscarPorId(int idHabClass)
        {
            return ctx.HabClasses.FirstOrDefault(e => e.IdHabClasses == idHabClass);
        }

        public void Cadastrar(HabClass novaHabClass)
        {
            ctx.HabClasses.Add(novaHabClass);

            ctx.SaveChanges();
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idHabClass)
        {
            HabClass habilidadeclasseBuscada = BuscarPorId(idHabClass);

            ctx.HabClasses.Remove(habilidadeclasseBuscada);

            ctx.SaveChanges();
        }

        public List<HabClass> Listar()
        {
            return ctx.HabClasses.ToList();
        }
    }
}
