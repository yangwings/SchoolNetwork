using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNetwork.Exceptions
{

    [Serializable]
    internal class AttributeMoreException : Exception
    {
        public AttributeMoreException() { }
        public AttributeMoreException(string message) : base($"方法{message}标注的特性过多") { }
        public AttributeMoreException(string message, Exception inner) : base(message, inner) { }
        protected AttributeMoreException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
