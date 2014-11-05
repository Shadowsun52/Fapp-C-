using System;
using System.Collections.Generic;
using System.Text;

namespace Fapp.Model
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public DateTime lastSync { get; set; }

        public override string ToString()
        {
            return this.email;
        }
    }
}
