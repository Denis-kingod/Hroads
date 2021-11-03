﻿using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> Listar();
        Personagem BuscarPorId(int idPersonagem);
        void AtualizarIdUrl(int idPersonagem, Personagem PersonagemAtualizada);
        void Cadastrar(Personagem novaPersonagem);
        void Deletar(int idPersonagem);
    }
}
