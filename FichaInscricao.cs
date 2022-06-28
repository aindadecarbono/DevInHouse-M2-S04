namespace DevInHouse;

public class FichaInscricao
{

  public string Nome { get; set; }

  public int Idade { get; set; }

  public string Curso { get; set; }

  public string Escolaridade { get; set; }

  public DateTime DataNascimento { get; set; }

  public decimal ValorCurso { get; set; }

  public decimal ValorDesconto { get; set; }

  public decimal ValorMulta { get; set; }

  public string TextoFormatado { get; set; }

  public FichaInscricao(string nome, string curso, string escolaridade, DateTime dataNascimento, decimal valorCurso, decimal valorDesconto, decimal valorMulta)
  {
    Nome = nome;
    Curso = curso;
    Escolaridade = escolaridade;
    DataNascimento = dataNascimento;
    ValorCurso = valorCurso;
    ValorDesconto = valorDesconto;
    ValorMulta = valorMulta;
    Idade = CalcularIdade();


    if (ValorDesconto == 0)
    {
      TextoFormatado = FormatacaoTexto.Formatar(Nome, Curso, ValorCurso);
    }
    else if (ValorDesconto > 0 && Idade < 18)
    {
      TextoFormatado = FormatacaoTexto.Formatar(Nome, Curso, ValorCurso, ValorDesconto, Idade);

    }
    else if (ValorDesconto > 0)
    {
      TextoFormatado = FormatacaoTexto.Formatar(Nome, Curso, ValorCurso, ValorDesconto);

    }
  }


  private int CalcularIdade()
  {
    DateTime dataAtual = DateTime.Now;
    return (int)dataAtual.Year - DataNascimento.Year;
  }
}

