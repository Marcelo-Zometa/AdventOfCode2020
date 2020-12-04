using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordPhilosophy
{
    public class Password
    {
        public Password(Policy policy, string password)
        {
            _Password = password;
            _Policy = policy;
        }

        public string _Password { get; set; }
        public Policy _Policy { get; set; }
    }
}
