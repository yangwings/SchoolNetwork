using System;

namespace SchoolNetwork.Attributes
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class OfflineAttribute : Attribute
    {
        public const string Name = "Offline";
    }
}
