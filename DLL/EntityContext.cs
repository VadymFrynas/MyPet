using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DAL
{
    public class EntityContext<T>
    {
        string Path;
        T[] EntitiesArray;
        IDataProvider<T> Provider;
        public EntityContext(string Path)
        {
            Provider = new JSONProvider<T>();
            this.Path = Path;
        }
        public string WriteToFIle(T[] entity)
        {
            Provider.Serialize(entity, Path);

            return "Successfully serialized";
        }
        public T[] ReadFromFile()
        {
            EntitiesArray = Provider.Deserialize(Path);
            return EntitiesArray;
        }
        public void DeleteAllInfo()
        {
            using (FileStream file = File.Create(Path)) { };
        }
    }
}