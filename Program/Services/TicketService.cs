using System;
using System.Collections.Generic;
using csharp_ticketmaster.Models;

namespace csharp_ticketmaster.Services
{
  public class TicketService
  {
    public List<string> Messages { get; set; }
    public List<Ticket> Tickets { get; set; }

    public TicketService()
    {
      Messages = new List<string>();
      Tickets = new List<Ticket>();
    }



    internal void CreateTicket(string title, string description)
    {
      Tickets.Add(new Ticket(title, description));
      //   Messages.Add("Ticket was added");
    }

    internal Ticket View(int index)
    {
      return Tickets[index];
    }
  }
}