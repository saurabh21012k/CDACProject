using DotnetBackend.Models;

public class DbContextFactory : IDbContextFactory
{
    private readonly IServiceProvider _serviceProvider;

    public DbContextFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public FarmFreshContext CreateDbContext()
    {
        return _serviceProvider.CreateScope().ServiceProvider.GetRequiredService<FarmFreshContext>();
    }
}