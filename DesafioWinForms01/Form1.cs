using System.Windows.Forms;

namespace DesafioWinForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        List<Curso> cursos = new List<Curso>();

        private void buscarArquivo(object sender, EventArgs e)
        {


            if (dialogSearch.ShowDialog() == DialogResult.OK)
            {
                Conector.carregarDados(pessoas, alunos, cursos, dialogSearch.FileName);
                MessageBox.Show($"Número de pessoas: {pessoas.Count()}\nNúmero de alunos: {alunos.Count()}");

                alunos.ForEach(aluno =>
                {
                    gridAlunos.Rows.Add(aluno.Nome, aluno.Curso.NomeCurso);
                    textBoxCaminhoArquivo.Text = dialogSearch.FileName;
                });
            }
        }

        private void listarAlunos(object sender, MouseEventArgs e)
        {
            if (pessoas.Count > 0)
            {
                pessoas.ForEach(pessoa =>
                {
                    gridPessoas.Rows.Add(pessoa.Nome, pessoa.Cidade, pessoa.Telefone, pessoa.Rg, pessoa.Cpf);
                });
            }

            if (cursos.Count > 0)
            {
                cursos.ForEach(curso =>
                {
                    gridCursos.Rows.Add(curso.CodigoCurso, curso.NomeCurso);
                });
                
            }
        }
    }
}