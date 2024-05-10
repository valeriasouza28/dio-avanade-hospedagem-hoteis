public class Hotel
{

  private const int CapacidadeMaximaSuites = 100; // Defina a capacidade máxima de suítes conforme necessário

  private string _nome;
  private int _qtdSuites;

  public string Nome
  {
    get { return _nome; }
    set { _nome = value.ToUpper(); } // Converte o nome para maiúsculas
  }

  public int QtdSuites
  {
    get { return _qtdSuites; }
    set
    {
      if (value < 1 || value > CapacidadeMaximaSuites) // Verifica se a quantidade de suítes é válida
      {
        throw new ArgumentException("A quantidade de suítes deve ser um número positivo e menor ou igual à capacidade máxima permitida.");
      }
      _qtdSuites = value;
    }
  }

  public Hotel() { }
  public Hotel(string nome, int qtdSuites)
  {
    Nome = nome;
    QtdSuites = qtdSuites;
  }
}
