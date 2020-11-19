using MediatR;
using OX.Application.Common.Interfaces;
using OX.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OX.Application.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommand : IRequest
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }

        public class Handler : IRequestHandler<CreateCompanyCommand>
        {
            private readonly IApplicationDBContext _context;
            private readonly IMediator _mediator;

            public Handler(IApplicationDBContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }
            public async Task<Unit> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
            {

                var entity = new Company()
                {

                    Name = request.Name,
                    Email = request.Email,
                    Logo = request.Logo
                };
                _context.Companies.Add(entity);
                await _context.SaveChangesAsync(cancellationToken);
                await _mediator.Publish(new CompanyCreated { CompanyId = entity.CompanyId.ToString() }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}

