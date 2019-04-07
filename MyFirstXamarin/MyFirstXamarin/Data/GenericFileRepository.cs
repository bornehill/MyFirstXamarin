using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MyFirstXamarin.Data
{
    public class GenericFileRepository<T> where T : IEntity  
    {
        private string FileName;

        public GenericFileRepository(string fileName)
        {
            FileName = fileName;
        }

        public T Get(int id)
        {
            var items = LoadEntities();
            return items.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return LoadEntities();
        }

        public void Save(T entity)
        {
            List<T> items = new List<T>();
            if (DependencyService.Get<IFile>().FileExists(FileName))
            {
                items = LoadEntities().ToList();
                var item = items.FirstOrDefault(i => i.Id == entity.Id);
                if (item != null)
                    items.Remove(item);
            }
            items.Add(entity);
            StoreEntities(items);
        }

        public void Save(IEnumerable<T> entities)
        {
            StoreEntities(entities);
        }

        public void Delete(int id)
        {
            var items = LoadEntities().ToList();
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
                items.Remove(item);
            StoreEntities(items);

        }

        private void StoreEntities(IEnumerable<T> entities)
        {
            var serializedEntities = JsonConvert.SerializeObject(entities);
            DependencyService.Get<IFile>().SaveText(FileName, serializedEntities);
        }

        private IEnumerable<T> LoadEntities()
        {
            var savedJson = DependencyService.Get<IFile>().LoadText(FileName);
            var deserializeTrayItems = JsonConvert.DeserializeObject<IEnumerable<T>>(savedJson);
            return deserializeTrayItems;
        }
    }
}
