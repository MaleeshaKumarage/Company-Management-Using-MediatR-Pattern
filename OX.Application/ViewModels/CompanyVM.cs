using OX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OX.Application.ViewModels
{
    public class CompanyVM
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }

        public CompanyVM()
        {

        }
        internal CompanyVM(Company company)
        {
            CompanyId = company.CompanyId;
            Name = company.Name;
            Email = company.Email;
            Logo = company.Logo;
        }
    }
}
