class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        id.ToString();

        id = new Guid("7a6b45ba-06da-400b-85c7-ce38048fca2f");
        Console.WriteLine(id.ToString().Substring(0, 8));

        id = Guid.NewGuid();
        Console.WriteLine(id.ToString().Substring(0, 8));
    }
}