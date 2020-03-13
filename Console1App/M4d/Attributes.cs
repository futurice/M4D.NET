using System;
using System.Collections.Generic;
using System.Text;

namespace Console1App
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeAttribute : Attribute
    {
        public AuthorizeAttribute(string claimType, Type property) { }
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class InAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class OutAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class SmallerThanAttribute : Attribute
    {
        public SmallerThanAttribute(PropValueKind valueKind, string property) { }
    }

    public enum PropValueKind
    {
        Unknown,
        Original,
        Updated
    }
}
