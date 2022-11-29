﻿using CleanEmployeeTimeTicketApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanEmployeeTimeTicketApp.Data
{
    
    /* (OCP) The EmployeeTimeTicketContext inherits from the DBContext. This way we can extend the DBContext 
     * in our application without modifying the actual dbcontext class. Using inheritence in this way allows us to 
     * extend according to the Open and Closed Principle of the SOLID principles. */
    public class EmployeeTimeTicketContext : DbContext
    {
        /*Dependency Inversion (DI)
         * This allows the app to create ann EmployeeTimeTicketContext that inherits a db context, 
         * pass it the options defined in startup, and
         * then pass the resulting object into the controller.
         * this is an example of Dependency Injection.*/
        public EmployeeTimeTicketContext(DbContextOptions<EmployeeTimeTicketContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeTicket> TimeTickets { get; set; }

    }
}