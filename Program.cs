using System;
namespace DevInHouse;

public class Program
{
  static void Main(string[] args)
  {
    FichaInscricao novaPessoa = new FichaInscricao("Bruno", "Fullstack", "Superior Completo", new DateTime(1991, 7, 27), 250M, 12M, 1M);
    System.Console.WriteLine(novaPessoa.TextoFormatado);
  }
}