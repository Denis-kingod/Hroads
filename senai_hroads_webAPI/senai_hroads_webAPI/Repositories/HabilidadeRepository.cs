﻿using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idHabilidade, Habilidade HabilidadeAtualizada)
        {
            Habilidade HabilidadeBuscada = ctx.Habilidades.Find(idHabilidade);

            if (HabilidadeAtualizada.IdTipoHabilidade != null && HabilidadeAtualizada.NomeHabilidade != null)
            {
                HabilidadeBuscada.IdTipoHabilidade = HabilidadeAtualizada.IdTipoHabilidade;
                HabilidadeBuscada.NomeHabilidade = HabilidadeAtualizada.NomeHabilidade;
            }

            ctx.Habilidades.Update(HabilidadeBuscada);

            ctx.SaveChanges();
        }

            public Habilidade BuscarPorId(int idHabilidade)
        {
            return ctx.Habilidades.FirstOrDefault(e => e.IdHabilidade == idHabilidade);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Update(novaHabilidade);
            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidade)
        {
            Habilidade HabilidadeBuscada = ctx.Habilidades.Find(idHabilidade);

            ctx.Habilidades.Remove(HabilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades
                
                //.Select(h => new Habilidade()
                //{
                //    IdHabilidade = h.IdHabilidade,
                //    NomeHabilidade = h.NomeHabilidade,

                //    IdTipoHabilidade = h.IdTipoHabilidade,

                //    IdTipoHabilidadeNavigation = new TipoHabilidade()
                //    {
                //        IdTipoHabilidade = h.IdTipoHabilidadeNavigation.IdTipoHabilidade,
                //        Tipo = h.IdTipoHabilidadeNavigation.Tipo
                //    }
                //})
                .ToList();
        }
    }
}
