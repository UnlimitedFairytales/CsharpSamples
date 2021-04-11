using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions
{
    public static class CloneExtension
    {
        public static T Clone<T>(this T serializableObject)
        {
            var formatter = new BinaryFormatter();
            var ms = new MemoryStream();
            formatter.Serialize(ms, serializableObject);
            ms.Position = 0;
            var cloned = formatter.Deserialize(ms);
            return (T)cloned;
        }
    }
}
