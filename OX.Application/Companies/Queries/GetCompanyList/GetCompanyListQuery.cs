using MediatR;
using Microsoft.EntityFrameworkCore;
using OX.Application.Common.Interfaces;
using OX.Application.ViewModels;
using OX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OX.Application.Companies.Queries.GetCompanyList
{
    public class GetCompanyListQuery : IRequest<List<CompanyVM>>
    {
        internal class GetCompanyListQueryHandler : IRequestHandler<GetCompanyListQuery, List<CompanyVM>>
        {
            private IApplicationDBContext _context;

            public GetCompanyListQueryHandler(IApplicationDBContext context)
            {
                _context = context;
            }
           
            public async Task<List<CompanyVM>> Handle(GetCompanyListQuery request, CancellationToken cancellationToken)
            {
                var entityList = await _context.Companies?.Select(a => new CompanyVM(a)).ToListAsync();
                return entityList;
            }
        }
    }
}
