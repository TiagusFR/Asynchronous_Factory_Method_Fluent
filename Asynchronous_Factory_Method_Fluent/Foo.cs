public class Foo
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    protected Foo()
    {
        Id = 0; 
        Name = "Default"; 
    }

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(100);
        Id = await GetIdFromServiceAsync();
        Name = "Initialized";
        return this;
    }

    public static Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return result.InitAsync();
    }

    private async Task<int> GetIdFromServiceAsync()
    {
        await Task.Delay(50);
        return 42;
    }
}
