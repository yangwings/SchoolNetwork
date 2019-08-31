using System;

namespace SchoolNetwork.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class LoginAttribute : Attribute
    {
        public int MyProperty { get; set; }
        public const string Name = "Login";
    }
}
