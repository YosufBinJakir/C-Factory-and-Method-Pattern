using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Tests
{
    public class DITest1
    {
        IRepositoryFactory factory;
        public DITest1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public  void Run()
        {
            IGenecricRepostory<Book> repo = this.factory.GetRepo<Book>();
            repo.Add(new Book { Id = 1, Title = "Dumb", Author = "Jerry", Price = 999.99M });
            repo.AddRange(new Book[] {
                new Book { Id = 2,Title = "Cheapskates", Author = "Mr. Cheap", Price = 999.99M},
                new Book { Id = 3,Title = "Destroy Towers", Author = "OB Laden", Price = 999.99M}
            });
            repo.Get()
                .ToList()
                .ForEach(b=> Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Price: {b.Price:C}"));
            Console.WriteLine();
            //update
            var book = repo.Get(2);
            book.Price = 899.99M;
            repo.Update(book);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Price: {b.Price:C}"));
            Console.WriteLine();
            //delete
            repo.Delete(1);
            repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Price: {b.Price:C}"));
            Console.WriteLine();

        }
    }
}
