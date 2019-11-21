namespace Domain.Entities
{
  public class Phone : Entity
  {
    public long Number { get; set; }
    public PhoneType PhoneType { get; set; }
    public int ContactId { get; set; }
    public Contact Contact { get; set; }
  }
}
