using CleanEmployeeTimeTicketApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CleanEmployeeTimeTicketApp.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeTimeTicketContext _dbContext;

        public HomeController(ILogger<HomeController> logger, EmployeeTimeTicketContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
    }
}
