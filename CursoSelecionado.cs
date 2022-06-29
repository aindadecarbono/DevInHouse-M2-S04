namespace DevInHouse;

internal class CursoSelecionado
{
  private List<string> Curso { get; set; }

  private void RecebeCurso(string curso)
  {
    Curso.Add(curso);
  }
}