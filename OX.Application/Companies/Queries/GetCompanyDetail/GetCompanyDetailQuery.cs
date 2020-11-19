using MediatR;
using OX.Application.Common.Interfaces;
using OX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OX.Application.Companies.Queries.GetCompanyDetail
{
    public class GetCompanyDetailQuery : IRequest<CompanyVM>
    {
        public int CompanyId { get; set; }
      
        internal class GetCompanyDetailQueryHandler : IRequestHandler<GetCompanyDetailQuery, CompanyVM>
        {
            private IApplicationDBContext _context;

            public GetCompanyDetailQueryHandler(IApplicationDBContext context)
            {
                _context = context;
            }
            public async Task<CompanyVM> Handle(GetCompanyDetailQuery request, CancellationToken cancellationToken)
            {
                var entity = await _context.Companies.FindAsync(request.CompanyId);

                return new CompanyVM(entity);
            }
        }
    }
}
