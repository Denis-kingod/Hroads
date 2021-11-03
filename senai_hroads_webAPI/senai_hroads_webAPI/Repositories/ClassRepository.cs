using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class ClassRepository : IClassRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idHabClass, Class ClassAtualizada)
        {
            Class classeBuscada = ctx.Classes.Find(idHabClass);

            if (ClassAtualizada.NomeClasse != null)
            {
                classeBuscada.NomeClasse = ClassAtualizada.NomeClasse;
            }

            ctx.Classes.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Class BuscarPorId(int idClass)
        {
            return ctx.Classes.FirstOrDefault(e => e.IdClasses == idClass);
        }

        public void Cadastrar(Class novaClass)
        {
            ctx.Classes.Add(novaClass);

            ctx.SaveChanges();
        }

        public void Deletar(int Class)
        {
            Class classeBuscada = BuscarPorId(Class);

            ctx.Classes.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Class> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
