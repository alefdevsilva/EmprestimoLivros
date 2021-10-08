using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoServices
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }



        public LivroClienteEmprestimoServices()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();

        }
    }
}
