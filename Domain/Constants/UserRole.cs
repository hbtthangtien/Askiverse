using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public static class UserRole
    {
        public const string BASIC_USER = "BASIC_USER";

        public const string PREMIUM_USER = "PREMIUM_USER";

        public const string ADMIN = "ADMIN";

        public static readonly string [] ALL =  [BASIC_USER, PREMIUM_USER];
    }
}
