using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net;
using WWL.Services;
using WWL.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WWL.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ApiController
    {
        private readonly AccountService accountService;
        private readonly LoginService loginService;

        public AccountController(AccountService accountService, LoginService loginService)
        {
            this.accountService = accountService;
            this.loginService = loginService;
        }


        // GET: api/<controller>
        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login(string account, string password)
        {
            var status = loginService.Login(account, password);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);
        }

        [Route("logout")]
        [HttpGet]
        public IHttpActionResult Logout(string account)
        {
            var status = loginService.Logout(account);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);
        }

        [Route("createAccount")]
        [HttpGet]
        public IHttpActionResult CreateAccount(string FNUsername, string email, string password)
        {
            var status = accountService.CreateAccount(FNUsername, email, password);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);

        }

        [Route("changeEmail")]
        [HttpGet]
        public IHttpActionResult ChangeEmail(string email)
        {
            var status = accountService.changeEmail(email);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);
        }

        [Route("changePassword")]
        [HttpGet]
        public IHttpActionResult ChangePassword(string password)
        {
            var status = accountService.changePassword(password);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);
        }

        [Route("changeUsername")]
        [HttpGet]
        public IHttpActionResult ChangeUsername(string FNUsername)
        {
            var status = accountService.changeUsername(FNUsername);
            if (status.status == true)
                return Ok(status.message);
            else
                return BadRequest(status.message);
        }
    }
}
