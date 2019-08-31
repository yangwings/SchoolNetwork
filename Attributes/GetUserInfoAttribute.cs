using System;

namespace SchoolNetwork.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public  sealed class GetUserInfoAttribute : Attribute
    {
        public const string Name = "GetUserInfo";
    }
}
