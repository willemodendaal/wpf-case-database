using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDatabase.Models
{
    /// <summary>
    /// Represents data entered on the login screen.
    /// </summary>
    public class LoginModel
    {
        public string AgentId { get; set; }
        public string Password { get; set; }
    }
}
