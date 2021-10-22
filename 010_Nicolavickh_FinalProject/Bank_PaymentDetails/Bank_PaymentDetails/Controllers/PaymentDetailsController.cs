using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_PaymentDetails.Controllers;
using Bank_PaymentDetails.Models;

namespace Bank_PaymentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private PaymentDetailsContext _context;
        public PaymentDetailsController(PaymentDetailsContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PaymentDetailsItem>> GetAllMoviesItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentDetailsContext)) as PaymentDetailsContext;
            return _context.GetAllPaymentDetails();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<PaymentDetailsItem>> GetMoviesItemById(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentDetailsContext)) as PaymentDetailsContext;
            return _context.GetPaymentDetailsById(id);
        }

        [HttpPost]
        public string AddMovies(PaymentDetailsItem details)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentDetailsContext)) as PaymentDetailsContext;
            return _context.AddPaymentDetails(details);
        }

        [HttpPut("{id}")]
        public string UpdateMovie(int id, PaymentDetailsItem details)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentDetailsContext)) as PaymentDetailsContext;
            return _context.UpdatePaymentDetails(id, details);
        }

        [HttpDelete("{id}")]
        public string DeletMovie(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentDetailsContext)) as PaymentDetailsContext;
            return _context.DeletePaymentDetails(id);
        }
    }
}

