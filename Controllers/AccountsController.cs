using Microsoft.AspNetCore.Mvc;
using foodies.DBModels;

namespace foodies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly foodiesdbContext _context;

        public AccountsController(foodiesdbContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            return _context.Accounts.ToList();
        }
        [HttpPost]
        public async Task<ActionResult<Account>> PostAccount(Account account)
        {
            _context.Accounts.Add(account);
            Console.WriteLine(account.UserId);           
            _context.SaveChanges();

            return new OkResult();
        }
    }
}
