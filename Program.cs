using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Interpolacao();
        ComparacaoDeString();
        StartsWithEndsWith();
        Equals();
        Indice();
        ToLowerToUpper();
        Replace();
        StringBuilder();
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

    static void Equals()
    {
        var texto = "Mais uma forma de testar comparação";
        Console.WriteLine(texto.Equals("mais uma forma de testar comparação"));
        Console.WriteLine(texto.Equals("Mais uma forma"));
        Console.WriteLine(texto.Equals("mais uma forma de testar comparação", StringComparison.OrdinalIgnoreCase));
    }

    static void Indice()
    {
        var texto = "Treinando com Índice";

        Console.WriteLine(texto.IndexOf("e"));
        Console.WriteLine(texto.LastIndexOf("e"));
    }

    static void ToLowerToUpper()
    {
        var texto = "Apenas um teste";

        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.ToUpper());

        Console.WriteLine(texto.Insert(3, "AQUI"));
        Console.WriteLine(texto.Remove(3, 2));
        Console.WriteLine(texto.Length);
    }

    static void Replace()
    {
        var texto = "Só testando";

        Console.WriteLine(texto.Replace("Só", "Apenas"));

        var divisao = texto.Split("t");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);

        var resultado = texto.Substring(3, 5);
        Console.WriteLine(resultado);
    }

    static void StringBuilder()
    {
        var texto = "Teste teste";
        texto += " aqui";

        Console.WriteLine(texto);

        var teste = new StringBuilder();
        teste.Append("Fazendo teste");
        teste.Append("com o construtor");
        teste.Append("de textos");

        Console.WriteLine(teste);
    }
}