namespace DevInHouse;

public static class FormatacaoTexto
{

  public static string Formatar(string nome, string curso, decimal valorCurso)
  {
    return $"Nome: {nome}, Curso: {curso}, Valor do curso: {valorCurso}";
  }

  public static string Formatar(string nome, string curso, decimal valorCurso, decimal valorDesconto)
  {
    return $"Nome: {nome}, Curso: {curso}, Valor do curso: {valorCurso}, Valor de desconto: {valorDesconto}";
  }

  public static string Formatar(string nome, string curso, decimal valorCurso, decimal valorDesconto, int idade)
  {
    return $"Nome: {nome}, Curso: {curso}, Valor do curso: {valorCurso}, Valor de desconto: {valorDesconto}, Idade: {idade}";
  }
}