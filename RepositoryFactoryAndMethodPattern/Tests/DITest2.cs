using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Tests
{
    public class DITest2
    {
        public void Run(IRepositoryFactory factory)
        {
            IGenecricRepostory<Publisher> repo = factory.GetRepo<Publisher>();
            repo.Add(new Publisher { Id = 1, PublisherName = "Pub 1", Contact = "01876XXXXXX", Email = "pub1@pub.pub" });
            repo.AddRange(new Publisher[]
            {
                new Publisher { Id = 2, PublisherName = "Pub 2", Contact = "01876XXXXXX", Email = "pub1@pub.pub" },
                new Publisher { Id = 3, PublisherName = "Pub 3", Contact = "01876XXXXXX", Email = "pub1@pub.pub" }
            });
            repo.Get()
                .ToList()
                .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.PublisherName},Contact: {p.Contact}, Email: {p.Email }"));
        }
    }
}
