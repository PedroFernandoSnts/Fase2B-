using System;

public class Banco
{
    private string _nome;
    private string _codigoBACEN;

    public string Nome
    {
        get { return _nome.ToUpper(); }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nome = value;
        }
    }

    public string CodigoBACEN
    {
        get { return _codigoBACEN; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _codigoBACEN = value;
        }
    }
}

public class Transacao
{
    private decimal _valor;

    public decimal Valor
    {
        get { return _valor; }
        set
        {
            if (value > 0)
                _valor = value;
        }
    }

    public DateTime Data { get; set; }
    public string ContaOrigem { get; set; }
    public string ContaDestino { get; set; }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco();
        banco.Nome = "Banco do Brasil";
        banco.CodigoBACEN = "001";

        Transacao t = new Transacao();
        t.Valor = 150;
        t.Data = DateTime.Now;
        t.ContaOrigem = "Conta A";
        t.ContaDestino = "Conta B";

        Console.WriteLine("Banco: " + banco.Nome);
        Console.WriteLine("Código BACEN: " + banco.CodigoBACEN);
        Console.WriteLine("Valor da Transação: " + t.Valor);
    }
}
