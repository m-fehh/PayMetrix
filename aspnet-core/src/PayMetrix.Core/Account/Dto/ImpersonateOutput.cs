using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMetrix.Account.Dto
{
    public class ImpersonateOutput
    {
        public string ImpersonationToken { get; set; }

        public string TenancyName { get; set; }
    }
}
