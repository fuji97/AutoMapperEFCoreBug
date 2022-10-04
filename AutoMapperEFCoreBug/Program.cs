using AutoMapper;
using AutoMapper.EquivalencyExpression;
using AutoMapperEFCoreBug;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddDbContext<FoobarDbContext>()
    .AddAutoMapper((serviceProvider, automapper) =>
    {
        automapper.AddCollectionMappers();
        automapper.UseEntityFrameworkCoreModel<FoobarDbContext>(serviceProvider);
        automapper.CreateMap<Foo, FooDto>().ReverseMap();
        automapper.CreateMap<Bar, BarDto>().ReverseMap();
    }, typeof(FoobarDbContext).Assembly)
    .BuildServiceProvider();

serviceProvider.GetRequiredService<IMapper>();