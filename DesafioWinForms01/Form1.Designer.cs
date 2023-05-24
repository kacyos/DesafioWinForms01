namespace DesafioWinForms01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dialogSearch = new OpenFileDialog();
            buttonBuscar = new Button();
            textBoxCaminhoArquivo = new TextBox();
            tabControl = new TabControl();
            tabPageAlunos = new TabPage();
            gridAlunos = new DataGridView();
            Aluno = new DataGridViewTextBoxColumn();
            curso = new DataGridViewTextBoxColumn();
            tabPagePessoas = new TabPage();
            gridPessoas = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            RG = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            tabPageCursos = new TabPage();
            gridCursos = new DataGridView();
            codigoCurso = new DataGridViewTextBoxColumn();
            nomeCurso = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabPageAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAlunos).BeginInit();
            tabPagePessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPessoas).BeginInit();
            tabPageCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCursos).BeginInit();
            SuspendLayout();
            // 
            // dialogSearch
            // 
            dialogSearch.FileName = "arquivo.dat";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(465, 43);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buscarArquivo;
            // 
            // textBoxCaminhoArquivo
            // 
            textBoxCaminhoArquivo.Location = new Point(118, 43);
            textBoxCaminhoArquivo.Name = "textBoxCaminhoArquivo";
            textBoxCaminhoArquivo.ReadOnly = true;
            textBoxCaminhoArquivo.Size = new Size(327, 23);
            textBoxCaminhoArquivo.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAlunos);
            tabControl.Controls.Add(tabPagePessoas);
            tabControl.Controls.Add(tabPageCursos);
            tabControl.Location = new Point(12, 108);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(661, 330);
            tabControl.TabIndex = 2;
            tabControl.MouseClick += listarAlunos;
            // 
            // tabPageAlunos
            // 
            tabPageAlunos.Controls.Add(gridAlunos);
            tabPageAlunos.Location = new Point(4, 24);
            tabPageAlunos.Name = "tabPageAlunos";
            tabPageAlunos.Padding = new Padding(3);
            tabPageAlunos.Size = new Size(653, 302);
            tabPageAlunos.TabIndex = 0;
            tabPageAlunos.Text = "Alunos";
            tabPageAlunos.UseVisualStyleBackColor = true;
            // 
            // gridAlunos
            // 
            gridAlunos.AllowUserToAddRows = false;
            gridAlunos.AllowUserToDeleteRows = false;
            gridAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAlunos.Columns.AddRange(new DataGridViewColumn[] { Aluno, curso });
            gridAlunos.Dock = DockStyle.Fill;
            gridAlunos.Location = new Point(3, 3);
            gridAlunos.Name = "gridAlunos";
            gridAlunos.ReadOnly = true;
            gridAlunos.RowTemplate.Height = 25;
            gridAlunos.Size = new Size(647, 296);
            gridAlunos.TabIndex = 0;
            // 
            // Aluno
            // 
            Aluno.HeaderText = "Aluno";
            Aluno.MinimumWidth = 302;
            Aluno.Name = "Aluno";
            Aluno.ReadOnly = true;
            Aluno.Resizable = DataGridViewTriState.False;
            Aluno.Width = 302;
            // 
            // curso
            // 
            curso.HeaderText = "Curso";
            curso.MinimumWidth = 302;
            curso.Name = "curso";
            curso.ReadOnly = true;
            curso.Width = 302;
            // 
            // tabPagePessoas
            // 
            tabPagePessoas.Controls.Add(gridPessoas);
            tabPagePessoas.Location = new Point(4, 24);
            tabPagePessoas.Name = "tabPagePessoas";
            tabPagePessoas.Padding = new Padding(3);
            tabPagePessoas.Size = new Size(653, 302);
            tabPagePessoas.TabIndex = 1;
            tabPagePessoas.Text = "Pessoas";
            tabPagePessoas.UseVisualStyleBackColor = true;
            // 
            // gridPessoas
            // 
            gridPessoas.AllowUserToAddRows = false;
            gridPessoas.AllowUserToDeleteRows = false;
            gridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPessoas.Columns.AddRange(new DataGridViewColumn[] { nome, cidade, telefone, RG, cpf });
            gridPessoas.Dock = DockStyle.Fill;
            gridPessoas.Location = new Point(3, 3);
            gridPessoas.Name = "gridPessoas";
            gridPessoas.ReadOnly = true;
            gridPessoas.RowTemplate.Height = 25;
            gridPessoas.Size = new Size(647, 296);
            gridPessoas.TabIndex = 0;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 130;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 130;
            // 
            // cidade
            // 
            cidade.HeaderText = "Cidade";
            cidade.MinimumWidth = 102;
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 102;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 130;
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 130;
            // 
            // RG
            // 
            RG.HeaderText = "rg";
            RG.MinimumWidth = 110;
            RG.Name = "RG";
            RG.ReadOnly = true;
            RG.Width = 110;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.MinimumWidth = 130;
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Width = 130;
            // 
            // tabPageCursos
            // 
            tabPageCursos.Controls.Add(gridCursos);
            tabPageCursos.Location = new Point(4, 24);
            tabPageCursos.Name = "tabPageCursos";
            tabPageCursos.Size = new Size(653, 302);
            tabPageCursos.TabIndex = 2;
            tabPageCursos.Text = "Cursos";
            tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // gridCursos
            // 
            gridCursos.AllowUserToAddRows = false;
            gridCursos.AllowUserToDeleteRows = false;
            gridCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCursos.Columns.AddRange(new DataGridViewColumn[] { codigoCurso, nomeCurso });
            gridCursos.Dock = DockStyle.Fill;
            gridCursos.Location = new Point(0, 0);
            gridCursos.Name = "gridCursos";
            gridCursos.ReadOnly = true;
            gridCursos.RowTemplate.Height = 25;
            gridCursos.Size = new Size(653, 302);
            gridCursos.TabIndex = 1;
            // 
            // codigoCurso
            // 
            codigoCurso.HeaderText = "Código";
            codigoCurso.MinimumWidth = 102;
            codigoCurso.Name = "codigoCurso";
            codigoCurso.ReadOnly = true;
            codigoCurso.Width = 102;
            // 
            // nomeCurso
            // 
            nomeCurso.HeaderText = "Curso";
            nomeCurso.MinimumWidth = 502;
            nomeCurso.Name = "nomeCurso";
            nomeCurso.ReadOnly = true;
            nomeCurso.Width = 502;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Caminho do arquivo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(label1);
            Controls.Add(tabControl);
            Controls.Add(textBoxCaminhoArquivo);
            Controls.Add(buttonBuscar);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPageAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAlunos).EndInit();
            tabPagePessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPessoas).EndInit();
            tabPageCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private FileSystemWatcher fileSystemWatcher1;
        private OpenFileDialog dialogSearch;
        private Button buttonBuscar;
        private TextBox textBoxCaminhoArquivo;
        private TabControl tabControl;
        private TabPage tabPageAlunos;
        private TabPage tabPagePessoas;
        private DataGridView gridAlunos;
        private DataGridView gridPessoas;
        private DataGridViewTextBoxColumn Aluno;
        private DataGridViewTextBoxColumn curso;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn cpf;
        private TabPage tabPageCursos;
        private DataGridView gridCursos;
        private DataGridViewTextBoxColumn codigoCurso;
        private DataGridViewTextBoxColumn nomeCurso;
    }
}