using System;
using System.Runtime.Serialization;

namespace RoslynDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pricePerOunce = 17.36m;
            var s = string.Format("The current price is {0} per ounce.", pricePerOunce);
        }

        string PrintString(object obj)
        {
            return obj.ToString();
        }

        public class Cereal : ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            protected Cereal(SerializationInfo serializationInfo, StreamingContext streamingContext)
            {
                throw new NotImplementedException();
            }
        }
    }
}
