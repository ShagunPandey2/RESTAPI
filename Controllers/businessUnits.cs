using BusinnessUnits.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinnessUnits.Controllers
{
    [Route("api/BusinessUnits")]
    [ApiController]
    public class businessUnits : ControllerBase
    {
        [HttpGet]
        public IEnumerable<accountName> GetAccountNames()
        {
            return AccountRepository.Accounts;
        }
        [HttpGet("{Id}")]
        public accountName GetAccountById(int Id)
        {
            return AccountRepository.Accounts.Where(i => i.ID == Id).FirstOrDefault();
        }
        [HttpDelete("{Id}")]
        public bool DeleteAccount(int Id)
        {
            var acc = AccountRepository.Accounts.Where(i => i.ID == Id).FirstOrDefault();
            AccountRepository.Accounts.Remove(acc);
            return true;
        }
        [HttpPost]
        
        public ActionResult<accountName> CreateAccount(accountName obj)
        {
            accountName acc = new accountName
            {
                ID = obj.ID,
                AccountName = obj.AccountName,
                BU_Head = obj.BU_Head


            };
            AccountRepository.Accounts.Add(acc);
            return Ok(obj);
        }

    }
}