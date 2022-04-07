using SSIP.Controllers;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Helper
{
    public static class Access
    {
        public static bool HighAuthorityAccess(User user)
        {
            var tools = new AccessController();

            var result = tools.ConfirmAuthority(user);

            if (result != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AuthorizeAccess(User user)
        {
            var tools = new AccessController();

            var result = tools.ConfirmAccess(user);

            if (result != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
