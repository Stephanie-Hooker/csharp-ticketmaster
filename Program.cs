using System;
using csharp_ticketmaster.Controllers;

namespace csharp_ticketmaster
{
  class Program
  {
    static void Main(string[] args)
    {
      new TicketController().Run();
    }
  }
}
