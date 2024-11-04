using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.Domain;
using ProxyLearning.Models.DTOs;

namespace ProxyLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var account = await _accountService.GetByIdAsync(id);
            return Ok(account);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountCreationRequest accountCreationRequest)
        {
            var newAccountId = await _accountService.CreateAsync(accountCreationRequest);
            return Created(new Uri($"/api/account/{newAccountId}", UriKind.Relative), newAccountId);
        }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> Put(int id, [FromBody] Account account)
        // {
        //     var updatedAccount = await _accountService.UpdateAccount(id, account);
        //     return Ok(updatedAccount);
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     await _accountService.DeleteAccount(id);
        //     return Ok();
        // }
    }
}
