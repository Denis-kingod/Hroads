using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idPersonagem, Personagem PersonagemAtualizada)
        {
            Personagem PersonagemBuscada = ctx.Personagems.Find(idPersonagem);
            if (PersonagemAtualizada.IdClasses != null && PersonagemAtualizada.NomePersonagem != null && PersonagemAtualizada.ManaMax != null && PersonagemAtualizada.VidaMax != null && PersonagemAtualizada.DataAtt != null && PersonagemAtualizada.DataCriada != null)
            {
                PersonagemBuscada.IdClasses = PersonagemAtualizada.IdClasses;
                PersonagemBuscada.NomePersonagem = PersonagemAtualizada.NomePersonagem;
                PersonagemBuscada.ManaMax = PersonagemAtualizada.ManaMax;
                PersonagemBuscada.VidaMax = PersonagemAtualizada.VidaMax;
                PersonagemBuscada.DataAtt = PersonagemAtualizada.DataAtt;
                PersonagemBuscada.DataCriada = PersonagemAtualizada.DataCriada;
            }

            ctx.Personagems.Update(PersonagemBuscada);

            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == idPersonagem);
        }

        public void Cadastrar(Personagem novaPersonagem)
        {
            ctx.Personagems.Update(novaPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            Personagem PersonagemBuscada = ctx.Personagems.Find(idPersonagem);

            ctx.Personagems.Remove(PersonagemBuscada);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}
