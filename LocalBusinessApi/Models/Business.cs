namespace LocalBusinessApi.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }
    public string Review { get; set; }
  }
}