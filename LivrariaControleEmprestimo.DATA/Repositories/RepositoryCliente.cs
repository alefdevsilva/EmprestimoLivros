﻿using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryCliente: RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SavesChanges = true) : base(SavesChanges)
        {

        }
    }
}
