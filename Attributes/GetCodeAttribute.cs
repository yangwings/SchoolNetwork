using System;

namespace SchoolNetwork.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class GetCodeAttribute : Attribute
    {
        public const string Name = "GetCode";
    }
}
