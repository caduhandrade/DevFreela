using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
