using System;
using csharp_ticketmaster.Models;
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
      Console.WriteLine("Number \t Title");
      Console.WriteLine("------------------");
      foreach (string message in _ticketService.Messages)
      {
        Console.WriteLine(message);

      }
      _ticketService.Messages.Clear();
      int index = 0;
      foreach (Ticket ticket in _ticketService.Tickets)
      {

        index++;
        Console.WriteLine($"{index} \t {ticket.Title}");
      }
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
          ViewTicket();
          break;
        case "new":
          NewTicket();
          break;
      }

    }

    private void NewTicket()
    {
      Console.WriteLine("Title: ");
      string title = Console.ReadLine();
      Console.WriteLine("Description: ");
      string description = Console.ReadLine();
      _ticketService.CreateTicket(title, description);

    }

    private void ViewTicket()
    {
      Console.WriteLine("Please select a number to view");
      if (int.TryParse(Console.ReadLine(), out int index))
      {
        Ticket ticket = _ticketService.View(index - 1);
        Console.Clear();
        Console.WriteLine($"Title: {ticket.Title} \n Description: {ticket.Description}");
        Console.WriteLine("select R to return to mian menu or Q to quit");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "r":
            Run();
            break;
          case "q":
            Environment.Exit(0);
            break;
        }
        Console.ReadLine();
      }
    }
  }
}