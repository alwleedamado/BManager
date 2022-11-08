using System.Runtime.Serialization;

namespace BManager.Controllers
{
    [Serializable]
    internal class EntityDataException : Exception
    {
        public EntityDataException()
        {
        }

        public EntityDataException(string message) : base(message)
        {
        }

        public EntityDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}