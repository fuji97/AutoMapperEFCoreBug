namespace AutoMapperEFCoreBug; 

public class Foo {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Bar> Bars = new List<Bar>();
}