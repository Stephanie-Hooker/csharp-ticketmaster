using csharp_ticketmaster.Interface;

namespace csharp_ticketmaster.Models
{
  public class Ticket : ITicket
  {

    public string Title { get; set; }
    public string Description { get; set; }

    public Ticket(string title, string description)
    {
      Title = title;
      Description = description;
    }
    public string GetTemplate()
    {
      string template = $"Tite: {Title} : Description: {Description}";
      return template;
    }



  }
}