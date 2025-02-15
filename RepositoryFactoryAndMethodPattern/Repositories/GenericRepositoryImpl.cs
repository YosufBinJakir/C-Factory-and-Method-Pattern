﻿using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Repositories
{
    public class GenericRepositoryImpl<T> : IGenecricRepostory<T> where T : EntityBase, new()
    {
        private  List<T> items = new List<T>();
        public IEnumerable<T> Get()
        {
            return items;
        }

        public T Get(int id)
        {
            return items.First(x => x.Id == id);
        }
        public void Add(T entity)
        {
            items.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            items.AddRange(entities);
        }

        public void Delete(int id)
        {
            var item=  items.First(x => x.Id == id);
            items.Remove(item);
        }

       

        public void Update(T entity)
        {
            int index = items.FindIndex(x=> x.Id == entity.Id);
            items.RemoveAt(index);
            items.Insert(index, entity);
        }
    }
}
