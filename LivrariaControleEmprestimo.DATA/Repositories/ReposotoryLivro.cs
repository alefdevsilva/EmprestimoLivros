using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class ReposotoryLivro:RepositoryBase<Livro>, IRepositoryLivro
    {
        public ReposotoryLivro(bool SavesChanges = true): base(SavesChanges)
        {

        }
    }
}
