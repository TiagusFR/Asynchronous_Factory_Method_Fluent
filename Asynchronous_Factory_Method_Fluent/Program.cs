class Program
{
    static async Task Main(string[] args)
    {
        var foo = await Foo.CreateAsync();
        Console.WriteLine($"Foo initialized with Id = {foo.Id}, Name = {foo.Name}");
    }
}
