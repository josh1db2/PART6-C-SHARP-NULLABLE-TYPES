﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PART6_NULLABLE_TYPES_IN_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketsOnSale = 100;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
        }
    }
}
