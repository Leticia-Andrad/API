﻿namespace API_DB.Models.ViewModels
{
    public class AlunoViewModel
    {
        public int IdAluno { get; set; }
        public string Aluno { get; set; }
        public string RM { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int IdTipoAluno { get; set; }
        public string TipoAluno { get; set; }
        public string? Tipo { get; internal set; }

        public static implicit operator AlunoViewModel(TipoAlunoViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
