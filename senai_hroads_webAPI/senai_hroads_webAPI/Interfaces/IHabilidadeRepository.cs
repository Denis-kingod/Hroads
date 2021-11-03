﻿using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();
        Habilidade BuscarPorId(int idHabilidade);
        void AtualizarIdUrl(int idHabilidade, Habilidade HabilidadeAtualizada);
        void Cadastrar(Habilidade novaHabilidade);
        void Deletar(int idHabilidade);
    }
}
