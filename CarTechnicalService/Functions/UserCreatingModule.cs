using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService.Objects;

namespace CarTechnicalService.Functions
{
    public class UserCreatingModule
    {
        List<Users> users = new List<Users>();

        public List<Users> ViewAllUsers()
        {
            return users;
        }
    }
}