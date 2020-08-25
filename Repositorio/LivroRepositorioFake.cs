using firstApk.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstApk.Repositorio
{
    public class LivroRepositorioFake : ILivroRepositorio
    {
        private ListaDeLeitura _paraLer;
        private ListaDeLeitura _lendo;
        private ListaDeLeitura _lidos;

        public LivroRepositorioFake()
        {
            var l1 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l2 = new Livro { Titulo = "Rathumflai no Rathumflei", Autor = "Stephen King" };
            var l3 = new Livro { Titulo = "Flex das estrelas", Autor = "Pericles" };

            _paraLer = new ListaDeLeitura("Para ler", l1);
            _lendo = new ListaDeLeitura("Lendo", l2);
            _lidos = new ListaDeLeitura("Lidos", l3); 
        }

        public ListaDeLeitura ParaLer => _paraLer;

        public ListaDeLeitura Lendo => _lendo;

        public ListaDeLeitura Lidos => _lidos;

        public IEnumerable<Livro> Todos => throw new System.NotImplementedException();

        public void Incluir(Livro livro)
        {
            throw new System.NotImplementedException();
        }
    }
}
