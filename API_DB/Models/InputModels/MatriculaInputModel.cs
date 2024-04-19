namespace API_DB.Models.InputModels
{
    public class MatriculaInputModel
    {
        public int IdAluno { get; set; }
        public DateOnly DataMatricula { get; set; }
        public int IdCurso { get; set; }
    }
}
