using LoginChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginChecker.Brokers
{
    internal interface IStorageBroker
    {
        Credential[] GetAllCredentials();

    }
}
