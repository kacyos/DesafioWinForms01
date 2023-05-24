using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioWinForms01
{
    internal class Conector
    {

        /// <summary>
        /// Método da Classe Conector, cria Alunos, Pessoas e Cursos e popula a lista de pessoas e alunos
        /// </summary>
        /// <param name="listaDePessoas"></param>
        /// <param name="listaDeAlunos"></param>
        public static void carregarDados(List<Pessoa> listaDePessoas, List<Aluno> listaDeAlunos, List<Curso> listDeCursos, string caminhoDoArquivo)
        {
            List<string> dados = DataBase.realizarLeituraDoArquivo(caminhoDoArquivo);

            try
            {

                Pessoa pessoa;
                Aluno aluno;
                Curso curso;

                dados.ForEach(item =>
                {

                    if (item.StartsWith("Z"))
                    {
                        string[] vetorPessoa = item.Split("-");
                        pessoa = new Pessoa(vetorPessoa[1], formatarTelefone(vetorPessoa[2]), vetorPessoa[3], formatarRG(vetorPessoa[4]), formatarCPF(vetorPessoa[5]));
                        listaDePessoas.Add(pessoa);
                    }
                    else if (item.StartsWith("Y"))
                    {

                        string[] vetorCurso = item.Split("-");
                        curso = new Curso(vetorCurso[2], vetorCurso[3]);
                        aluno = new Aluno(listaDePessoas.Last().Nome, listaDePessoas.Last().Telefone, listaDePessoas.Last().Cidade, listaDePessoas.Last().Rg, listaDePessoas.Last().Cpf, vetorCurso[1], curso);

                        if (!listDeCursos.Contains(curso))
                        {
                            listDeCursos.Add(curso);
                        }

                        listaDeAlunos.Add(aluno);
                       
                    }

                });
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao ler o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

        }

        private static string formatarTelefone(string telefone)
        {
            string padrao = @"(\d{2})(\d{4,5})(\d{4})";
            string formato = "($1) $2-$3";

            string numeroFormatado = Regex.Replace(telefone, padrao, formato);
            return numeroFormatado;
        }

        public static string formatarRG(string rg)
        {
            string padrao = @"(\d{2})(\d{3})(\d{3})(\d{1})";
            string formato = "$1.$2.$3-$4";

            string rgFormatado = Regex.Replace(rg, padrao, formato);
            return rgFormatado;
        }

        public static string formatarCPF(string cpf)
        {
            string padrao = @"(\d{3})(\d{3})(\d{3})(\d{2})";
            string formato = "$1.$2.$3-$4";

            string cpfFormatado = Regex.Replace(cpf, padrao, formato);
            return cpfFormatado;
        }

    }
}
