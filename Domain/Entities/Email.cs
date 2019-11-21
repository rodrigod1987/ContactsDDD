namespace Domain.Entities
{
  public class Email : Entity
  {
    public string Mail { get; set; }
    public MailType MailType { get; set; }
    public int ContactId { get; set; }
    public Contact Contact { get; set; }
  }
}
