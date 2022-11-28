﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanEmployeeTimeTicketApp.Data
{
    public class Project
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public double Budget { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<TimeTicket> TimeTickets { get; set; } = new List<TimeTicket>();

    }
}
