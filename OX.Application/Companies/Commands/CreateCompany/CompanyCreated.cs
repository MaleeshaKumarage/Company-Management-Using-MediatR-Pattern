using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OX.Application.Common.Interfaces;
using OX.Application.Notifications.Models;

namespace OX.Application.Companies.Commands.CreateCompany
{
    public class CompanyCreated : INotification
    {
        public string CompanyId { get; set; }

        public class CompanyCreatedHandler : INotificationHandler<CompanyCreated>
        {
            private readonly INotificationService _notification;

            public CompanyCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(CompanyCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new MessageDto());
            }
        }
    }
}
