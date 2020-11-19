using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OX.Domain
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
