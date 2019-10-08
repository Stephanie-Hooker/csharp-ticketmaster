using System;
using csharp_ticketmaster.Services;

namespace csharp_ticketmaster.Controllers
{
  public class TicketController
  {
    private TicketService _ticketService = new TicketService();

    public void Run()
    {
      while (true)
      {
        Update();
        GetUserInput();
      }
    }

    private void Update()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Ticket-master\n");
      foreach (string message in _ticketService.Messages)
      {
        Console.WriteLine(message);

      }
      _ticketService.Messages.Clear();
    }
    private void GetUserInput()
    {
      Console.WriteLine("Please select an option: (New, View, Quit)");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "quit":
          Environment.Exit(0);
          break;
        case "view":
          _ticketService.Messages.Add("please select a ticket to view");

          break;
        case "new":
          _ticketService.Messages.Add("please add in a new ticket");
          break;

      }

    }

  }
}