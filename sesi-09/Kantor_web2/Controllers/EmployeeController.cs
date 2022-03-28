using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_web2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// for more info

namespace Kantor_Web2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController :  ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        // GET user
        [HttpGet(Name = "Get Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //return new string[]
            return _context.GetAllEmployee();
        }

        // GET user id
        [HttpGet("{id}", Name = "Get Employee where ")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }
    }
}