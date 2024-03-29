﻿using SantaMarta.Bussines.AccountsBussines;
using SantaMarta.Data.Models.Accounts;
using System.Collections.Generic;
using System.Web.Http;

namespace SantaMarta.WebAPI.Controllers
{
    public class AccountsController : ApiController
    {
        // GET: api/Accounts
        [HttpGet]
        public IHttpActionResult GetInvoicesAllSales()
        {
            IList<Accounts> account = null;

            AccountsB accountB = new AccountsB();

            account = accountB.GetAll();

            if (account == null)
            {
                Ok(false);
            }

            return Ok(account);
        }

        // GET: api/Accounts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Accounts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Accounts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Accounts/5
        public void Delete(int id)
        {
        }
    }
}
