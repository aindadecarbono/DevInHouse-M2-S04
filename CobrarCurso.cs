namespace DevInHouse;

public class CobrarCurso
{
  private double ValorCurso { get; set; }
  private double ValorMulta { get; set; }
  private double ValorDesconto { get; set; }

  public double Resultado { get; set; }

  private void Calculo()
  {
    if (ValorMulta > 0)
      Resultado = ValorCurso + ValorMulta;
    else if (ValorMulta == 0)
      Resultado = ValorCurso - ValorDesconto;
  }
}