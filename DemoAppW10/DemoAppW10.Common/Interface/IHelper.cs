using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppW10.Common.Interface
{
    public interface IHelper
    {
        bool IsInternet();

        Task<string> Get(string url);

        Task ShowMessage(string messageText, string messageHeader);

    }
}
