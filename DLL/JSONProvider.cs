using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace DAL
{
    public class JSONProvider<T> : IDataProvider<T>
    {

        DataContractJsonSerializer JSONFormatter = new DataContractJsonSerializer(typeof(T[]));

        public void Serialize(T[] entity, string Path)
        {
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                JSONFormatter.WriteObject(fs, entity);
            }
        }

        public T[] Deserialize(string Path)
        {
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                T[] deserilizePeople = (T[])JSONFormatter.ReadObject(fs);
                return deserilizePeople;

            }
        }
    }
}
