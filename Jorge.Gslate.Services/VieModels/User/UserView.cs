using System;
using System.Collections.Generic;
using System.Text;

namespace Jorge.Gslate.Services.VieModels.User
{
    public class UserView
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
