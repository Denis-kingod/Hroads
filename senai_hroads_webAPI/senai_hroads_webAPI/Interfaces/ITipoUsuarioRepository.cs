﻿using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();
        TipoUsuario BuscarPorId(int idTipoUsuario);
        void AtualizarIdUrl(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizada);
        void Cadastrar(TipoUsuario novaTipoUsuario);
        void Deletar(int idTipoUsuario);
    }
}
