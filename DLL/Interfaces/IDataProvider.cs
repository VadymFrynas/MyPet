using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDataProvider<T>
    {
        void Serialize(T[] entity, string Path);
        T[] Deserialize(string Path);

    }
}
