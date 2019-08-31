using SchoolNetwork.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNetwork.Interfaces
{
    public interface IWebMethod
    {
        bool Login(string username,string password, string code,ref CookieContainer cookies);
        Image GetCodeImage(ref CookieContainer cookies);
        void OffLine(ref CookieContainer cookies);
    }
}
