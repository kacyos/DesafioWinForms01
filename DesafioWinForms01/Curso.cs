using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWinForms01
{
    internal class Curso
    {
        private string _codigoCurso;
        private string _nomeCurso;

        public Curso(string codigoCurso, string nomeCurso)
        {
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }

        public string CodigoCurso { get => _codigoCurso; set => _codigoCurso = value; }
        public string NomeCurso { get => _nomeCurso; set => _nomeCurso = value; }
    }
}
