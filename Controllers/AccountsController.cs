using Microsoft.AspNetCore.Mvc;
using foodies.Models;

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
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            return _context.Accounts.ToList();
        }
        [HttpPost]
        public ActionResult<Account> PostAccount(Account account)
        {
            _context.Accounts.Add(account);
            Console.WriteLine(account.UserId);           
            _context.SaveChanges();

            return new OkResult();
        }
    }
}
