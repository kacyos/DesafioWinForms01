using System.Windows.Forms;

namespace DesafioWinForms01
{
    public partial class Lista : Form
    {
        public Lista()
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
                pessoas.Clear();
                alunos.Clear();
                cursos.Clear();

                Conector.carregarDados(pessoas, alunos, cursos, dialogSearch.FileName);

                alunos.ForEach(aluno =>
                {
                    gridAlunos.Rows.Add(aluno.Nome, aluno.Curso.NomeCurso);
                    textBoxCaminhoArquivo.Text = dialogSearch.FileName;
                });





                if (alunos.Count > 0)
                {
                    MessageBox.Show($"Número de pessoas: {pessoas.Count()}\nNúmero de alunos: {alunos.Count()}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void listarPessoasECursos(object sender, EventArgs e)
        {

            // Verificando qual TabPage foi selecionado
            if (tabControl.SelectedTab == tabPagePessoas && pessoas.Count > 0 && gridPessoas.Rows.Count == 0)
            {
                pessoas.ForEach(pessoa =>
                {
                    gridPessoas.Rows.Add(pessoa.Nome, pessoa.Cidade, pessoa.Telefone, pessoa.Rg, pessoa.Cpf);
                });
            }
            else if (tabControl.SelectedTab == tabPageCursos && cursos.Count > 0 && gridCursos.Rows.Count == 0)
            {

                cursos.ForEach(curso =>
                {
                    gridCursos.Rows.Add(curso.CodigoCurso, curso.NomeCurso);
                });
            }

        }
    }
}