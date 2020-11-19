using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OX.Application.Companies;
using OX.Application.Companies.Commands.CreateCompany;
using OX.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OX.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private IMediator _mediator;
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<List<CompanyVM>> GetAsync()
        {
            var vmList = await _mediator.Send(new OX.Application.Companies.Queries.GetCompanyList.GetCompanyListQuery());
            return vmList;
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<CompanyVM> GetAsync(int id)
        {
            var vm = await _mediator.Send(new OX.Application.Companies.Queries.GetCompanyDetail.GetCompanyDetailQuery() { CompanyId = id });

            return vm;
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            var command = new CreateCompanyCommand() { CompanyId = 1, Name = "AAAA", Email = "ddddd@ffff.com", Logo = new byte[] { } };
           var k=_mediator.Send(command);
            return Ok(k);
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
