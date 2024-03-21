using DotnetBackend.Models;

public interface IDbContextFactory
{
    FarmFreshContext CreateDbContext();
}