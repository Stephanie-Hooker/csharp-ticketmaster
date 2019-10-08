using System.Collections.Generic;

namespace csharp_ticketmaster.Services
{
  public class TicketService
  {
    public List<string> Messages { get; set; }

    public TicketService()
    {
      Messages = new List<string>();
    }
  }
}