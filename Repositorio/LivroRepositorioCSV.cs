using firstApk.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace firstApk.Repositorio
{
    public class LivroRepositorioCSV : ILivroRepositorio
    {
        private static string nomeArquivoCSV = @"C:\Users\Usuario\source\repos\firstApk\livros.csv";

        private ListaDeLeitura _paraLer;
        private ListaDeLeitura _lendo;
        private ListaDeLeitura _lidos;

        public LivroRepositorioCSV()
        {
            var arrayParaLer = new List<Livro>();
            var arrayLendo = new List<Livro>();
            var arrayLidos = new List<Livro>();
            
            using (var file = File.OpenText(LivroRepositorioCSV.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var textoLivro = file.ReadLine();
                    if (string.IsNullOrEmpty(textoLivro))
                    {
                        continue;
                    }
                    var infoLivro = textoLivro.Split(';');
                    var livro = new Livro
                    {
                        Id = Convert.ToInt32(infoLivro[1]),
                        Titulo = infoLivro[2],
                        Autor = infoLivro[3]
                    };
                    switch (infoLivro[0])
                    {
                        case "para-ler":
                            arrayParaLer.Add(livro);
                            break;
                        case "lendo":
                            arrayLendo.Add(livro);
                            break;
                        case "lidos":
                            arrayLidos.Add(livro);
                            break;
                        default:
                            break;
                    }
                }
            }

            _paraLer = new ListaDeLeitura("Para Ler", arrayParaLer.ToArray());
            _lendo = new ListaDeLeitura("Lendo", arrayLendo.ToArray());
            _lidos = new ListaDeLeitura("Lidos", arrayLidos.ToArray());
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
