using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNetwork.Interfaces
{
    public interface IWebMethodExpand
    {
        string[] UserInfo(ref CookieContainer cookies);
    }
}
