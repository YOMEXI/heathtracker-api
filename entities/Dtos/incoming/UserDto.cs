using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entities.Dtos.incoming
{
    public class UserDto
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public string? DateOfBirth { get; set; }
        public string? Country { get; set; }

        public string? id { get; set; }
    }
}