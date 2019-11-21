namespace Domain.Entities
{
  public class Address : Entity
  {
    public string Street { get; set; }
    public int Number { get; set; }
    public long PostalCode { get; set; }
    public string County { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int ContactId { get; set; }
    public Contact Contact { get; set; }
    
  }
}
