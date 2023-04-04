class Program
{
    static void Main(string[] args)
    {
        Interpolacao();
        ComparacaoDeString();
        StartsWithEndsWith();
    }

    static void Interpolacao()
    {
        var price = 10.2;
        // var texto = ("O preço do produto é " + price + " apenas na promoção");
        // var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
        var texto = $"O preço do produto é {price} apenas na promoção";
        Console.WriteLine(texto);
    }

    static void ComparacaoDeString()
    {
        var texto = "Testando";

        Console.WriteLine(texto.CompareTo("testando"));
        Console.WriteLine(texto.CompareTo("Testando"));
        Console.WriteLine(texto.Contains("Tes"));
        Console.WriteLine(texto.Contains("testa", StringComparison.OrdinalIgnoreCase));
    }

    static void StartsWithEndsWith()
    {
        var texto = "Este texto é um teste.";
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este"));
        Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(texto.EndsWith("test"));
        Console.WriteLine(texto.EndsWith("Teste.", StringComparison.OrdinalIgnoreCase));
    }


}