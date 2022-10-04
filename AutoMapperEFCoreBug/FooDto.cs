namespace AutoMapperEFCoreBug; 

public class FooDto {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<BarDto> Bars = new ();
}
