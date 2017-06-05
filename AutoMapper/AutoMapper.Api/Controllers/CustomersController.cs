using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper.Api.Models;

namespace AutoMapper.Api.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Values
        public IEnumerable<CustomerDto> Get()
        {
            var customers=new List<Customer>
            {
                new Customer {CustomerId = 1,Name = "Ahasan",Email = "aha",PromoCode = 5},
                new Customer {CustomerId = 2,Name = "Habib",Email = "habib",PromoCode = 6}
            };
            var cus = Mapper.Map<IEnumerable<CustomerDto>>(customers);
            return cus;
        }

        // GET: api/Values/5
        public CustomerDto Get(int id)
        {
            var customer = new Customer {CustomerId = 1, Name = "Ahasan", Email = "aha", PromoCode = 5};
            
            var cus = Mapper.Map<CustomerDto>(customer);
            var cus1 = Mapper.Map<Customer>(cus);
            return cus;
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
