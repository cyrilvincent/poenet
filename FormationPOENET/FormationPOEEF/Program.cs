using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationPOEEF
{
    class Program
    {
        static void Main(string[] args)
        {
            FormationModel db = new FormationModel();
            List<Book> books = db.Books.ToList(); // GetAll
            Book b = db.Books.Find(1); // GetById
            Book book = new Book { Title = "C#", Price = 10 };
            db.Books.Add(book);
            db.SaveChanges();
            b.Price += 1;
            db.SaveChanges();
            db.Books.Remove(book);
            db.SaveChanges();
            books = db.Books.Where(b2 => b2.Price <= 10).ToList(); //Lambda
            books = db.Publishers.Where(p => p.Name == "ENI").First().Books.ToList();
            



        }
    }
}
