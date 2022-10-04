using Microsoft.EntityFrameworkCore;
namespace AutoMapperEFCoreBug; 

public class FoobarDbContext : DbContext {
    public DbSet<Foo> Foos { get; set; } = null!;
    public DbSet<Bar> Bars { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseInMemoryDatabase("TestDb");
    }

    protected FoobarDbContext() {
    }

    public FoobarDbContext(DbContextOptions options) : base(options) {
    }
}
